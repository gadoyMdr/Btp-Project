using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PointerGrab : MonoBehaviour, IActionWhenInteractedWith
{
    public Action<GameObject, bool> ActionTriggerd { get; set; }

    [SerializeField]
    private Rigidbody2D _rigidbody2D;

    public void TriggerAction(object[] parameters)
    {
        Vector3 worldCursorPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        gameObject.transform.position = new Vector3(worldCursorPos.x, worldCursorPos.y, transform.position.z);
        _rigidbody2D.gravityScale = 0;
        ActionTriggerd?.Invoke(gameObject, true);
    }

    public void TurnOffAction()
    {
        _rigidbody2D.gravityScale = 1;
        _rigidbody2D.velocity = Vector2.zero;
        ActionTriggerd?.Invoke(gameObject, false);
    }

}


