using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class Material : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D _rigidbody;

    //used so we don't pick up the item when it's already picked up
    
    public bool isPickedUp = false;

    [HideInInspector]
    public SpriteRenderer _spriteRenderer;

    private Color baseColor;
    public bool canBePickedUp;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        baseColor = _spriteRenderer.color;
    }

    public void SwitchToPickedUp()
    {
        canBePickedUp = false;
        isPickedUp = true;
        _rigidbody.gravityScale = 0;
    }

    public void SwitchToDropped()
    {
        isPickedUp = false;
        _rigidbody.gravityScale = 1;
    }

    /// <summary>
    /// Change the color to green if true or red if false and to normal if not hovered
    /// true = material in range
    /// </summary>
    /// <param name="value"></param>
    public void SetToHovered(bool? value)
    {
        if (value.HasValue)
        {
            canBePickedUp = value.Value;
            if (value.Value) _spriteRenderer.color = Color.green;
            else _spriteRenderer.color = Color.red;
        }
        else
        {
            canBePickedUp = false;
            _spriteRenderer.color = baseColor;
        }
        
    }

}
