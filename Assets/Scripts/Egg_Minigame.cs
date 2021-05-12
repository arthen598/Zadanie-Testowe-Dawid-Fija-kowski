using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Egg_Minigame : MonoBehaviour
{
    [Header("References")]
    MinigameInput Input;
    public TextMeshProUGUI ScoreUI;
    public SpriteRenderer Wolf;
    public Transform[] WolfPositions; /* #0 - Left #1 - Right*/
    public SpriteRenderer[] Buttons;
    /* #0 - Left Up
     * #1 - Left Down
     * #2 - Right Up
     * #3 - Right Down*/
    public Sprite[] WolfSprites;
    public Sprite[] ButtonSpr; /*#0- Off  #1- On */
    public EggContainer[] Containers;
    public Animator LoseLifeAnimator;
    public Animator[] Lifes;
    public GameObject[] ButtonsGraphic; // #0 - PC #- Xbox
    

    public enum Positions
    {
        LeftUp, LeftDown, RightUp, RightDown
    };
    [Header("Minigame Data")]
    bool Disable = false;
    [SerializeField] Positions WolfPosition;
     int Score = 0;
    int Life = 4;
    private float StartTickTime;
    private float StartSpawnTime;
    public AnimationCurve Tick;
    public AnimationCurve Spawn;
    [Range(0f,1f)]
    public float HardValue;
    
    
    private void Awake()
    {
        Input = new MinigameInput();
        LeftUp();
        Buttons[0].sprite = ButtonSpr[0];
        Input.Minigame.LeftUp.performed +=  ctx =>{ LeftUp(); ChangeButtonGraphic(ctx.control.device); };
        Input.Minigame.LeftDown.performed += ctx => { LeftDown(); ChangeButtonGraphic(ctx.control.device); };
        Input.Minigame.RightUp.performed += ctx => { RightUp(); ChangeButtonGraphic(ctx.control.device); };
        Input.Minigame.RightDown.performed += ctx => { RightDown(); ChangeButtonGraphic(ctx.control.device); };
        Input.Minigame.LeftUp.canceled += ctx => Buttons[0].sprite = ButtonSpr[0];
        Input.Minigame.LeftDown.canceled += ctx => Buttons[1].sprite = ButtonSpr[0];
        Input.Minigame.RightUp.canceled += ctx => Buttons[2].sprite = ButtonSpr[0];
        Input.Minigame.RightDown.canceled += ctx => Buttons[3].sprite = ButtonSpr[0];
        
        SetHardnessCurve();
        StartTickTime = Tick.Evaluate(0f);
        StartSpawnTime = Spawn.Evaluate(0f);
    }
    private void OnEnable()
    {
        Input.Enable();
        ResetGame();  
    }
    private void OnDisable()
    {
        Input.Disable();
        StopAllCoroutines();
    }

    
    IEnumerator EggSpawnTick()
    {
        while (true)
        {
            SpawnEgg();
            yield return new WaitForSeconds(GetSpawnTime());
        }
    }

    public void SpawnEgg()
    {
        int random = Random.Range(0, Containers.Length);
        Containers[random].EnableEggSpawn();
    }

    public void ResetGame()
    {
        Debug.Log("reset");
        StopGame();
        setScore(0);
        Life = 4;
        HardValue = 0;
        foreach (var item in Containers)
        {
            item.ResetContainer();
        }
        CheckLifeAnimation();
        StartCoroutine(EggSpawnTick());
    }

    private void LeftUp()
    {
        Wolf.transform.position = WolfPositions[0].position;
        Wolf.sprite = WolfSprites[0];
        Buttons[0].sprite = ButtonSpr[1];
        WolfPosition = Positions.LeftUp;
    }
    private void LeftDown()
    {
        Wolf.transform.position = WolfPositions[0].position;
        Wolf.sprite = WolfSprites[1];
        Buttons[1].sprite = ButtonSpr[1];
        WolfPosition = Positions.LeftDown;
    }
    private void RightUp()
    {
        Wolf.transform.position = WolfPositions[1].position;
        Wolf.sprite = WolfSprites[2];
        Buttons[2].sprite = ButtonSpr[1];
        WolfPosition = Positions.RightUp;
    }
    private void RightDown()
    {
        Wolf.transform.position = WolfPositions[1].position;
        Wolf.sprite = WolfSprites[3];
        Buttons[3].sprite = ButtonSpr[1];
        WolfPosition = Positions.RightDown;
    }

    public void setScore(int _score)
    {
        Score = _score;
        ScoreUI.text = Score.ToString();
        ChangeHardness();
    }
    public int getScore()
    {
        return Score;
    }
    public Positions GetWolfPosition()
    {
        return WolfPosition;
    }
    public void LoseLife(Positions eggPosition)
    {
        if (!LoseLifeAnimator.GetBool("IsAnimated"))
        {
            if (eggPosition == Positions.LeftDown || eggPosition == Positions.LeftUp)
            {
                LoseLifeAnimator.transform.localPosition = new Vector3(-2.2f, -2.1f, 0);
                LoseLifeAnimator.transform.localScale = new Vector3(-1.5f, 1.5f, 1);
            }
            else if (eggPosition == Positions.RightDown || eggPosition == Positions.RightUp)
            {
                LoseLifeAnimator.transform.localPosition = new Vector3(2f, -2.1f, 0);
                LoseLifeAnimator.transform.localScale = new Vector3(1.5f, 1.5f, 1);
            }
            LoseLifeAnimator.SetTrigger("Broke");
            Life--;
            CheckLifeAnimation();
            if(Life == 0)
            {
                StopGame();
                StartCoroutine(EndGameOnLose());
            }

        }
    }

    private void CheckLifeAnimation()
    {
        if(Life == 4)
        {
            Lifes[0].GetComponent<SpriteRenderer>().enabled = false;
            Lifes[1].GetComponent<SpriteRenderer>().enabled = false;
            Lifes[2].GetComponent<SpriteRenderer>().enabled = false;
        }
        else if(Life == 3)
        {
            Lifes[2].GetComponent<SpriteRenderer>().enabled = true;
            Lifes[2].SetBool("DontFlash", true);
        }
        else if (Life == 2)
        {
            Lifes[1].GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (Life == 1)
        {
            Lifes[1].SetBool("DontFlash", true);
            Lifes[0].GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (Life == 0)
        {
            Lifes[0].SetBool("DontFlash", true);
        }
    }

    public float GetTickTime()
    {
        return Tick.Evaluate(HardValue);
    }

    public float GetSpawnTime()
    {
        return Spawn.Evaluate(HardValue);
    }

    IEnumerator EndGameOnLose()
    {
        yield return new WaitWhile(() => LoseLifeAnimator.GetBool("IsAnimated"));
        ResetGame();
    }

    public void StopGame()
    {
        StopAllCoroutines();
        foreach (var con in Containers)
        {
            con.StopContainerRun();
        }
    }

    public void ChangeHardness()
    {
        float value = Mathf.InverseLerp(0, 1000, Score);
        HardValue = value;
    }

    private void SetHardnessCurve()
    {
        Keyframe[] TickKeys = new Keyframe[]
        {
            new Keyframe(0f,0.7f),
            new Keyframe(0.1f,0.65f),
            new Keyframe(0.2f,0.60f),
            new Keyframe(0.3f,0.59f),
            new Keyframe(0.4f,0.58f),
            new Keyframe(0.5f,0.57f),
            new Keyframe(0.6f,0.56f),
            new Keyframe(0.7f,0.55f),
            new Keyframe(0.8f,0.53f),
            new Keyframe(0.9f,0.51f),
            new Keyframe(1f,0.50f)
        };
        Tick.keys = TickKeys;

        Keyframe[] SpawnKeys = new Keyframe[]
        {
            new Keyframe(0f,3.5f),
            new Keyframe(0.1f,1.5f),
            new Keyframe(0.2f,1.4f),
            new Keyframe(0.3f,1.3f),
            new Keyframe(0.4f,1.2f),
            new Keyframe(0.5f,1.1f),
            new Keyframe(0.6f,1f),
            new Keyframe(0.7f,0.9f),
            new Keyframe(0.8f,0.85f),
            new Keyframe(0.9f,0.75f),
            new Keyframe(1f,0.6f)
        };
        Spawn.keys = SpawnKeys;
    }

    public void ChangeButtonGraphic(UnityEngine.InputSystem.InputDevice device)
    {
        Debug.Log(device.displayName);
        if(device.displayName == "Keyboard")
        {
            ButtonsGraphic[0].SetActive(true);
            ButtonsGraphic[1].SetActive(false);
        }
        else if (device.displayName == "Xbox Controller")
        {
            ButtonsGraphic[0].SetActive(false);
            ButtonsGraphic[1].SetActive(true);
        }
    }
}
