using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseManager : MonoBehaviour
{
    
    void Update()
    {
        CheckIfAnyHovered();
    }

    void CheckIfAnyHovered()
    {
        Vector2 hitPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        RaycastHit2D hit = Physics2D.Raycast(hitPos, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent(out IHoverable ihoverable))
            {

            }
        }
        
            
    }
}
