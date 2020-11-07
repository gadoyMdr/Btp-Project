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

    public void Jump()
    {

    }
}
