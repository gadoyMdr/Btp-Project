using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class LayerSelection : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI layerText;

    [SerializeField]
    InputAction changeLayer;

    private Layer CurrentLayer;
    
    public Layer currentLayer
    {
        get => CurrentLayer;
        set
        {
            CurrentLayer = value;
            UpdateTextLayer();
        }
    }

    private PropertyInfo[] allLayers;

    private int currentLayerInt = 0;

    

    private void Start()
    {
        changeLayer.performed += _ => ChangeLayer();
        allLayers = Type.GetType("Layer").GetProperties();
        UpdateTextLayer();
    }

    private void OnEnable()
    {
        changeLayer.Enable();
    }

    private void OnDisable()
    {
        changeLayer.Disable();
    }

    void ChangeLayer()
    {
        currentLayer = (Layer) allLayers[currentLayerInt].GetValue(null);
        currentLayerInt++;
        if (currentLayerInt > allLayers.Length - 1) currentLayerInt = 0;
    }

    void UpdateTextLayer()
    {
        layerText.text = $"Layer : {currentLayer.layerName}";
    }

}
