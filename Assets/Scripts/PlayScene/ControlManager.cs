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
    PlaySceneUIManager playSceneUIManager;

    private void Awake()
    {
        controls = new Controls();
    }

    public void Start()
    {
        playerCrouch = FindObjectOfType< PlayerCrouch>();
        playerJump = playerCrouch.GetComponent<PlayerJump>();
        playerMove = playerCrouch.GetComponent<PlayerMove>();
        materialController = playerCrouch.GetComponent<MaterialController>();
        playSceneUIManager = FindObjectOfType<PlaySceneUIManager>();

        SetControlsCallBacks();
    }

    void SetControlsCallBacks()
    {
        controls.PlayerMovements.Right.performed += _ => playerMove.direction = 1;
        controls.PlayerMovements.Right.canceled += _ => playerMove.direction = 0;

        controls.PlayerMovements.Left.performed += _ => playerMove.direction = -1;
        controls.PlayerMovements.Left.canceled += _ => playerMove.direction = 0;

        controls.PlayerMovements.Up.performed += _ => playerJump.Jump();

        controls.PlayerMovements.Down.performed += _ => playerCrouch.Crouch();
        controls.PlayerMovements.Down.performed += _ => playerCrouch.DeCrouch();

        controls.PlayerMaterials.Scroll.performed += x => materialController.RotateMaterial(x.ReadValue<float>());

        controls.UI.TogglePause.performed += _ => playSceneUIManager.TogglePause(null);
    }

    private void OnEnable()
    {
        controls.PlayerMovements.Enable();
        controls.PlayerMaterials.Enable();
        controls.UI.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerMovements.Disable();
        controls.PlayerMaterials.Disable();
        controls.UI.Disable();
    }
}


