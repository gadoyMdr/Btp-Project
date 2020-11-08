using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class RotateMaterials : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Don't use the drag feature to change this veriable.")]
    private int rotateStep = 5;

    private Rigidbody2D _rigidbody;


    //Called when any variable is changed in inspector
    private void OnValidate() => RoundNumberNextModulo();
    

    private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();
    

    public void Rotate(float x)
    {
        if(x > 0) _rigidbody.MoveRotation(_rigidbody.rotation + rotateStep);
        if(x < 0) _rigidbody.MoveRotation(_rigidbody.rotation - rotateStep);
    }

    //Consider refactoring
    //Make it so the rotation always end up at 360 and not 361 whatsoever
    void RoundNumberNextModulo()
    {
        int temp = rotateStep;

        while (360 % temp != 0) temp++;

        rotateStep = Mathf.Min(temp, 180);
    }
}
