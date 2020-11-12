using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IVisualWhenInteractedWith
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    Color changedColor;

    public void TriggerVisual(object[] parameters)
    {
        //_spriteRenderer.color = changedColor;
    }

    public void TurnOffVisual()
    {
        //_spriteRenderer.color = Color.white;
    }
}
