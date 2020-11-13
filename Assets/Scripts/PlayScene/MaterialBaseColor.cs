using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaterialBaseColor : MonoBehaviour
{
    private ChangeColor _changeColor;
    private SpriteRenderer spriteRenderer;
    private Material material;

    private void Awake()
    {
        _changeColor = GetComponent<ChangeColor>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        material = GetComponent<Material>();
    }

    private void OnEnable() => _changeColor.VisualTriggered += ApplyBaseColor;
    

    private void OnDisable() => _changeColor.VisualTriggered -= ApplyBaseColor;


    void ApplyBaseColor(GameObject go, bool value)
    {
        if (!value)
            spriteRenderer.color = material.layer.colorSet;
        else
            spriteRenderer.color = material.layer.selectedColor;
        
    }
}
