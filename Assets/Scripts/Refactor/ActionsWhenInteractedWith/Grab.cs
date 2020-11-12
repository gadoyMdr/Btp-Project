using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Interact))]
public class Grab : MonoBehaviour, IActionWhenInteractedWith
{
    public Action<GameObject, bool> ActionTriggerd { get; set; }

    [SerializeField]
    private Transform grabPoint;

    public new Rigidbody2D rigidbody2D;

    private SpringJoint2D _springJoint2D;

    public void TriggerAction(object[] paramaters)
    {
        Player player = (Player)paramaters[0];

        _springJoint2D = player.gameObject.AddComponent<SpringJoint2D>();
        _springJoint2D.connectedBody = rigidbody2D;
        _springJoint2D.anchor = player.grabPoint.position;
        _springJoint2D.connectedAnchor = grabPoint.position;
        _springJoint2D.frequency = 5;
        _springJoint2D.dampingRatio = 0.7f;

        ActionTriggerd?.Invoke(gameObject, true);
    }

    public void TurnOffAction()
    {
        if (_springJoint2D != null)
        {
            Destroy(_springJoint2D);
            ActionTriggerd?.Invoke(gameObject, false);
        }
    }

}
