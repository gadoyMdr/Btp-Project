using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ShopDetection : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DetectShop();
        }
    }

    private void DetectShop()
    {
        Vector2 hitPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(hitPos, Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.TryGetComponent(out Shop shop))
                {
                    shop.OpenShop();
                }
            }
    }
}
