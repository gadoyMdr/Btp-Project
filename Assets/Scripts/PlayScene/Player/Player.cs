using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]

public class Player : MonoBehaviour
{
    public Transform grabPoint;
    [Range(0, 50)]
    public float armLenght;
}
