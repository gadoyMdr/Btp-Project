using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameObjectHoverDetection : MonoBehaviour
{
    public Material DetectHoverGameObject(out Vector2 hitPos)
    {

        hitPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        RaycastHit2D hit = Physics2D.Raycast(hitPos, Vector2.zero);

        if (hit.collider != null)
            if (hit.collider.TryGetComponent(out Material material))
                return material;
        

        return null;
    }
}
