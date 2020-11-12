using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyLayer : MonoBehaviour
{
    private IActionWhenInteractedWith interactedWith;
    private LayerSelection layerSelection;
    private void Awake()
    {
        interactedWith = GetComponent<IActionWhenInteractedWith>();
        layerSelection = FindObjectOfType<LayerSelection>();
    }

    private void OnEnable()
    {
        interactedWith.ActionTriggerd += ApplyLayerFunction;
    }

    private void OnDisable()
    {
        interactedWith.ActionTriggerd -= ApplyLayerFunction;
    }

    void ApplyLayerFunction(GameObject go, bool b)
    {
        if(!b)
            go.GetComponent<Material>().ApplyLayer(layerSelection.currentLayer);
    }
}
