using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Material : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D _rigidbody;

    [HideInInspector]
    public bool isPickedUp = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void SwitchToPickedUp()
    {
        isPickedUp = true;
    }

    public void SwitchToDropped()
    {
        isPickedUp = false;
    }
}
