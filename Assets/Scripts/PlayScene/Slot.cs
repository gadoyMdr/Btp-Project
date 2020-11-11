using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Slot : MonoBehaviour
{
    public static Action<Material> BuyRequest;

    [SerializeField]
    private TextMeshProUGUI textPrice;

    [SerializeField]
    private Image materialImage;

    private Material material;

    public void SetParameters(Material material)
    {
        materialImage.sprite = material._spriteRenderer.sprite;
        textPrice.text = $"{material.price} $";
        this.material = material;
    }

    public void ClickOnSlot() => BuyRequest?.Invoke(material);
    
    
}
