using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupText : MonoBehaviour
{
    [HideInInspector]
    public Transform transformToFollow;

    private void Update()
    {
        transform.position = new Vector3(transformToFollow.position.x, transformToFollow.position.y);
    }

    public void ChangeText(string text)
    {
        GetComponent<TextMeshProUGUI>().text = text;
    }
}
