using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChickenBehaviour : MonoBehaviour
{
    public GameObject Info;
    public GameObject Minigame;
    PlayerController OnTriggerController;
    bool MinigameStarted = false;
    System.Action<InputAction.CallbackContext> handler;

    private void OnTriggerEnter(Collider other)
    {
        Info.SetActive(true);
        OnTriggerController = other.GetComponent<PlayerController>();
        handler = (InputAction.CallbackContext ctx) => ChangeControls();
        OnTriggerController.PlayerControls.Player.Action.performed += handler;  
    }
    private void OnTriggerExit(Collider other)
    {
        Info.SetActive(false);
        OnTriggerController.PlayerControls.Player.Action.performed -= handler;
        OnTriggerController = null;
    }
   
    private void ChangeControls()
    {
        if (MinigameStarted == false)
        {
            OnTriggerController.PlayerControls.Player.Movement.Disable();
            OnTriggerController.PlayerControls.Player.Rotation.Disable();
            MinigameStarted = true;
            Minigame.SetActive(true);
            Info.SetActive(false);
            InputDevice device = OnTriggerController.PlayerControls.Player.Action.activeControl.device;
            Minigame.GetComponent<Egg_Minigame>().ChangeButtonGraphic(device);
        }
        else
        {
            OnTriggerController.PlayerControls.Player.Movement.Enable();
            OnTriggerController.PlayerControls.Player.Rotation.Enable();
            MinigameStarted = false;
            Minigame.SetActive(false);
            Info.SetActive(true);
        }
    }
}
