using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{

    #region Stats
    [Header("Jump stats")]
    [SerializeField]
    private float baseJumpHeight;

    [HideInInspector]
    public float multiJumpHeight;

    private float currentJumpHeight;

    #endregion

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        currentJumpHeight = baseJumpHeight;
    }

    public void Jump()
    {
        _rigidbody.AddForce(Vector2.up * currentJumpHeight, ForceMode2D.Impulse);
    }
}
