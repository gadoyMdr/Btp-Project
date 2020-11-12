using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopupEvent : MonoBehaviour, IVisualWhenInteractedWith
{
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
    }

    public void TurnOffVisual()
    {
        if (popupTextInstance != null)
            Destroy(popupTextInstance.gameObject);
    }
}
