using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public MainControls PlayerControls;
    CharacterController control;
    Vector2 MoveDirection;
    Vector2 RotateDirection;
    public float RotationSpeed;
    public float MovementSpeed;
    
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        control = GetComponent<CharacterController>();
        PlayerControls = new MainControls();
        PlayerControls.Player.Movement.performed += ctx => 
        {
            MoveDirection = ctx.ReadValue<Vector2>();
        };
        PlayerControls.Player.Movement.canceled += ctx =>
        {
            MoveDirection = Vector2.zero;
        };
        PlayerControls.Player.Rotation.performed += ctx => 
        {
            RotateDirection = ctx.ReadValue<Vector2>();
        };
        PlayerControls.Player.Rotation.canceled += ctx =>
        {
            RotateDirection = Vector2.zero;
        };
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        Vector3 Final = new Vector3(MoveDirection.x * MovementSpeed, 0, MoveDirection.y*MovementSpeed);
        transform.Translate((Vector3.right * Final.x + Vector3.forward * Final.z) * Time.deltaTime);
    }
 
    private void Rotate()
    {
        float Final = RotateDirection.x;
        transform.Rotate( (Vector3.up * Final) * Time.deltaTime * RotationSpeed);
    }

    private void OnEnable()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();
    }
}
