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

    [SerializeField]
    [Tooltip("The Maximum velocity")]
    [Range(0, 10)]
    private float maxVelocity;

    [SerializeField]
    [Tooltip("The smaller, the faster the player will stop")]
    [Range(0, 1)]
    private float speedFallOff;

    #endregion

    [HideInInspector]
    public float multiSpeed;


    private int Direction;
    public int direction
    {
        get => Direction;
        set
        {
            Direction = value;
            FlipVisuals();
        }
    }

    private float currentSpeed;
    private Rigidbody2D _rigidbody;

    private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();
    

    private void Start() => currentSpeed = baseSpeed;
    

    private void Update()
    {
        if (direction != 0) Move();
        else DecreaseSpeed();
    }
    
    //Move 
    //Consider refactoring
    public void Move()
    {
        _rigidbody.velocity = new Vector2(
            direction > 0 ?
            Mathf.Min(maxVelocity, _rigidbody.velocity.x + direction * currentSpeed * Time.deltaTime) :
            Mathf.Max(-maxVelocity, _rigidbody.velocity.x + direction * currentSpeed * Time.deltaTime), 
            _rigidbody.velocity.y);

    }
    //Decrease speed when the player doesnt input any movement
    void DecreaseSpeed()
    {
        _rigidbody.velocity = new Vector2(
            Mathf.Lerp(0, _rigidbody.velocity.x, speedFallOff * (Time.deltaTime * 1000)),
            _rigidbody.velocity.y);
    }

    //flip visuals 
    //TODO : update : visuals need to change to the whole transform
    void FlipVisuals()
    {
        if(direction != 0)
        {
            transform.rotation = Quaternion.Euler(
             transform.transform.rotation.x,
             direction < 0 ? 180 : 0,
             transform.transform.rotation.y
            );
        }
        
    }
}
