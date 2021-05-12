using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggContainer : MonoBehaviour
{
    public Egg_Minigame MinigameControl;
    public SpriteRenderer[] eggs;
    public Egg_Minigame.Positions Position;
    public List<int> values;
    bool MakeEgg = false;

    private void PaintEggs()
    {
        for (int i = 0; i < eggs.Length; i++)
        {
            Color color = eggs[i].color;
            color.a = 0.2f;
            eggs[i].color = color;
        }

        foreach (var item in values)
        {
            Color color = eggs[item].color;
            color.a = 1f;
            eggs[item].color = color;
        }
    }
   public void EnableEggSpawn()
    {
        MakeEgg = true;
    }
    public void DisableEggSpawn()
    {
        MakeEgg = false;
    }
    public void AddEgg()
    {
        if (!values.Contains(0))
        {
            values.Add(0);
            PaintEggs();
        }
    }
    public void EggGoDown()
    {
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] <= eggs.Length-2)
            {
                values[i]++;
            }
            else
            {
                values.RemoveAt(i);
                CheckScore();
                i--;
            }
        }
        if(MakeEgg == true)
        {
            AddEgg();
            DisableEggSpawn();
        }
        PaintEggs();
    }

    public void StopContainerRun()
    {
        StopAllCoroutines();
    }
    public void ResetContainer()
    {
        StopContainerRun();
        values = new List<int>();
        MakeEgg = false;
        PaintEggs();
        StartCoroutine(EggLoseTick());
    }

    private void CheckScore()
    {
        if(MinigameControl.GetWolfPosition() == Position)
        {
            MinigameControl.setScore(MinigameControl.getScore() + 1);
        }
        else
        {
            MinigameControl.LoseLife(Position);
        }
    }

    IEnumerator EggLoseTick()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        while (true)
        {
            yield return new WaitForSeconds(MinigameControl.GetTickTime());
            yield return new WaitWhile(() => MinigameControl.LoseLifeAnimator.GetBool("IsAnimated"));
            EggGoDown();
        }
    }
}
