using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrabManager : MonoBehaviour
{
    [SerializeField]
    private Transform grabPoint;

    Controls controls;
    private IGrabable objectGrabbed;
    private SpringJoint2D _springJoint2D;
    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        controls.PlayerInteraction.Grab.performed += _ => TryGrab();
        controls.PlayerInteraction.Grab.canceled += _ => Release();
    }

    private void OnEnable()
    {
        controls.PlayerInteraction.Enable();
    }

    private void OnDisable()
    {
        controls.PlayerInteraction.Disable();
    }

    void TryGrab()
    {
        objectGrabbed = GameObject.FindObjectsOfType<MonoBehaviour>().OfType<IGrabable>().
            Where(x => x.canBeInteractedWith).FirstOrDefault();

        if(objectGrabbed != null)
        {
            objectGrabbed.isInteractedWith = true;

            AddSpringAndConfigure();
        }
            
    }

    void Release()
    {
        Destroy(_springJoint2D);
        if(objectGrabbed != null) objectGrabbed.isInteractedWith = false;
        objectGrabbed = null;
    }

    void AddSpringAndConfigure()
    {
        _springJoint2D = gameObject.AddComponent<SpringJoint2D>();
        _springJoint2D.connectedBody = objectGrabbed.rigidbody2D;
        _springJoint2D.anchor = grabPoint.position;
        _springJoint2D.connectedAnchor = objectGrabbed.handleTransform.position;
        _springJoint2D.frequency = 10;
    }
}
