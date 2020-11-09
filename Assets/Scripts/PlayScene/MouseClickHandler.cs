using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
[RequireComponent(typeof(HoverMaterial))]
[RequireComponent(typeof(MaterialProjection))]
[RequireComponent(typeof(PlaceMaterial))]
public class MouseClickHandler : MonoBehaviour
{
    EquipItem _equipItem;
    MaterialProjection _materialProjection;
    PlaceMaterial _placeMaterial;
    HoverMaterial _hoverMaterial;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
        _materialProjection = GetComponent<MaterialProjection>();
        _hoverMaterial = GetComponent<HoverMaterial>();
        _placeMaterial = GetComponent<PlaceMaterial>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
            DoItsThing();
    }

    void DoItsThing()
    {
        if(_equipItem.currentMaterial != null)
        {
            if (_hoverMaterial.currentlyHoveredMaterial == null)
            {
                _placeMaterial.PlaceMaterialFunction(_equipItem.currentMaterial, _materialProjection.projectionPoint.position, _materialProjection.projectionPoint.rotation);
            }

            if (_hoverMaterial.currentlyHoveredMaterial != null)
            {
                _equipItem.SwitchMaterial(_equipItem.currentMaterial);
            }
        }
        else
        {
            if(_hoverMaterial.currentlyHoveredMaterial != null)
                _equipItem.TryEquip(_hoverMaterial.currentlyHoveredMaterial);
        }
        
    }
}
