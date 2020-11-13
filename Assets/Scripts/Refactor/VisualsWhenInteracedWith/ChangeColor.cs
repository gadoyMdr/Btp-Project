using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IVisualWhenInteractedWith
{
    public Action<GameObject, bool> VisualTriggered { get; set; }

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    Color changedColor;


    /// <summary>
    /// Both functions below results are overode if someone is subscribed
    /// </summary>
    /// <param name="parameters"></param>
    public void TriggerVisual(object[] parameters)
    {
        if(VisualTriggered == null)
            _spriteRenderer.color = changedColor;
        else
            VisualTriggered.Invoke(gameObject, true);
    }

    public void TurnOffVisual()
    {
        if (VisualTriggered == null)
            _spriteRenderer.color = Color.white;
        else
            VisualTriggered.Invoke(gameObject, false);
    }
}
