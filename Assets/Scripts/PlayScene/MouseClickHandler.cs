using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        //We're holding a material
        if(_equipItem.currentMaterial != null)
        {
            //We place it on the map
            if (_hoverMaterial.currentlyHoveredMaterial == null && !_materialProjection.projection.isProjectionOverlapping)
            {
                _placeMaterial.PlaceMaterialFunction(_equipItem.currentMaterial, _materialProjection.projection.transform.position, _materialProjection.projection.transform.rotation);
            }
            //We switch with another material



            if (_hoverMaterial.currentlyHoveredMaterial != null && !_materialProjection.projection.isProjectionOverlapping)
            {
                _equipItem.SwitchMaterial(_hoverMaterial.currentlyHoveredMaterial);
            }
        }
        //We're not holding any material
        else
        {
            //We click on a material
            if(_hoverMaterial.currentlyHoveredMaterial != null)
                _equipItem.TryEquip(_hoverMaterial.currentlyHoveredMaterial);
                
            
                
        }
        
    }
}
