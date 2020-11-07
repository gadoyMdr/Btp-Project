using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    #region Stats
    [Header("Movement stats")]
    [SerializeField]
    private float baseSpeed;

    #endregion

    [HideInInspector]
    public float multiSpeed;

    [HideInInspector]
    public float direction;

    private float currentSpeed;

    private SpriteRenderer _playerSprite;

    private void Awake()
    {
        _playerSprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (direction != 0) Move();
    }

    public void Move()
    {
        _playerSprite.flipX = direction < 0;
    }
}
