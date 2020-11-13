using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopupEvent : MonoBehaviour, IVisualWhenInteractedWith
{
    public Action<GameObject, bool> VisualTriggered { get; set; }

    [SerializeField]
    private PopupText popupTextPrefab;

    [SerializeField]
    private Transform transformPopupTextToFollow;

    [SerializeField]
    private string text;

    private PopupText popupTextInstance;

    public void TriggerVisual(object[] parameters)
    {
        if(popupTextInstance == null)
            popupTextInstance = Instantiate(popupTextPrefab, GameObject.Find("WorldSpaceCanvas").transform);

        popupTextInstance.ChangeText(text);
        popupTextInstance.transformToFollow = transformPopupTextToFollow == null ? transform : transformPopupTextToFollow;
        VisualTriggered?.Invoke(gameObject, true);
    }

    public void TurnOffVisual()
    {
        if (popupTextInstance != null)
        {
            Destroy(popupTextInstance.gameObject);
            VisualTriggered?.Invoke(gameObject, false);
        }
            
    }
}
