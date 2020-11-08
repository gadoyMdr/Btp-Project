using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    PlayerCrouch playerCrouch;
    PlayerJump playerJump;
    PlayerMove playerMove;
    MaterialController materialController;
    Controls controls;

    private void Awake()
    {
        controls = new Controls();

        playerCrouch = FindObjectOfType<PlayerCrouch>();
        playerJump = playerCrouch.GetComponent<PlayerJump>();
        playerMove = playerCrouch.GetComponent<PlayerMove>();
        materialController = playerCrouch.GetComponent<MaterialController>();
    }

    void Start()
    {
        controls.PlayerMovements.Right.performed += _ => playerMove.direction = 1;
        controls.PlayerMovements.Right.canceled += _ => playerMove.direction = 0;

        controls.PlayerMovements.Left.performed += _ => playerMove.direction = -1;
        controls.PlayerMovements.Left.canceled += _ => playerMove.direction = 0;

        controls.PlayerMovements.Up.performed += _ => playerJump.Jump();

        controls.PlayerMovements.Down.performed += _ => playerCrouch.Crouch();
        controls.PlayerMovements.Down.performed += _ => playerCrouch.DeCrouch();

        controls.PlayerMaterials.Scroll.performed += x => materialController.RotateMaterial(x.ReadValue<float>());
    }

    private void OnEnable()
    {
        controls.PlayerMovements.Enable();
        controls.PlayerMaterials.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerMovements.Disable();
        controls.PlayerMaterials.Disable();
    }
}


