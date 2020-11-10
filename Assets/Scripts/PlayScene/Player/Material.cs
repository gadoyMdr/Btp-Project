using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
public class Material : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D _rigidbody;

    [HideInInspector]
    public SpriteRenderer _spriteRenderer;

    //used so we don't pick up the item when it's already picked up
    public bool isPickedUp = false;

    public bool canBePickedUp;

    private Hover Hover;
    public Hover hover
    {
        get => Hover;
        set
        {
            Hover = value;
            UpdateHover();
        }
    }

    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
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
    /// 

    void UpdateHover()
    {

    }

    public void SetToHovered(bool? value)
    {
        if (value.HasValue)
        {
            canBePickedUp = value.Value;
            if (value.Value) _spriteRenderer.color = new Color(0, 255, 0, 0.4f);
            else _spriteRenderer.color = new Color(255, 0, 0, 0.4f); ;
        }
        else
        {
            canBePickedUp = false;
            _spriteRenderer.color = Color.white;
        }
        
    }

}
