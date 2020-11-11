using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class Material : MonoBehaviour
{
    public SpriteRenderer _spriteRenderer;

    [HideInInspector]
    public Rigidbody2D _rigidbody;

    public float price;

    //used so we don't pick up the item when it's already picked up
    public bool isPickedUp = false;

    private MaterialState MaterialState;
    public MaterialState materialState
    {
        get => MaterialState; 
        set
        {
            MaterialState = value;
            UpdateState();
        }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void SwitchToPickedUp()
    {
        isPickedUp = true;
        _rigidbody.gravityScale = 0;
    }

    public void SwitchToDropped()
    {
        _rigidbody.velocity = Vector2.zero;
        isPickedUp = false;
        _rigidbody.gravityScale = 1;
    }

    /// <summary>
    /// Change the color to green if true or red if false and to normal if not hovered
    /// true = material in range
    /// </summary>
    /// <param name="value"></param>
    /// 

    void UpdateState()
    {
        _spriteRenderer.color = materialState.color;
    }

}
