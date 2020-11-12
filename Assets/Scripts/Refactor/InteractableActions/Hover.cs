using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hover : MonoBehaviour, Iinteractable
{
    public Action<bool> CanBeInteractedWith { get; set; }

    private bool gateMouseHover = false;
    private bool tempMouseHover = false;

    private bool IsHovered;
    
    public bool isHovered
    {
        get => IsHovered;
        set
        {
            IsHovered = value;
            CanBeInteractedWith?.Invoke(value);
        }
    }

    private void Update()
    {
        CheckIfMouseHover();
    }

    bool CheckIfHover()
    {
        Vector2 hitPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


        RaycastHit2D hit = Physics2D.Raycast(hitPos, Vector2.zero);

        if (hit.collider != null)
            return hit.collider.gameObject.Equals(gameObject);
        else return false;
    }

    public void CheckIfMouseHover()
    {
        if (CheckIfHover())
            gateMouseHover = true;
        else
            gateMouseHover = false;


        if (gateMouseHover != tempMouseHover)
        {
            if (gateMouseHover) isHovered = true;
            else isHovered = false;

            tempMouseHover = gateMouseHover;
        }
    }
}
