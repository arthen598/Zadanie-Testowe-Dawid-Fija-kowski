using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    MainControls controls;

    private void Awake()
    {
        controls = new MainControls();
        controls.Application.Exit.performed += ctx => ExitGame();
        controls.Application.Exit.Enable();
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
