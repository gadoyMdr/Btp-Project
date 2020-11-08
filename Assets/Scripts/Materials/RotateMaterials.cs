using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class RotateMaterials : MonoBehaviour
{
    [SerializeField]
    private int rotateStep = 5;
    private Rigidbody2D _rigidbody;

    private void OnValidate()
    {
        RoundNumberNextModulo();
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Rotate(float x)
    {
        if(x > 0) _rigidbody.MoveRotation(_rigidbody.rotation + rotateStep);
        if(x < 0) _rigidbody.MoveRotation(_rigidbody.rotation - rotateStep);
    }


    void RoundNumberNextModulo()
    {
        int temp = rotateStep;

        while (360 % temp != 0) temp++;

        rotateStep = Mathf.Min(temp, 180);
    }
}
