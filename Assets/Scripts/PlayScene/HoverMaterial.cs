using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
[RequireComponent(typeof(MaterialProjection))]
public class HoverMaterial : MonoBehaviour
{

    [SerializeField]
    private float maxRange = 5;

    [HideInInspector]
    public Material currentlyHoveredMaterial;

    private EquipItem _equipItem;
    private MaterialProjection _materialProjection;
    private Material lastMaterial = null;
    private bool gate = false;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
        _materialProjection = GetComponent<MaterialProjection>();
    }

    private void Update()
    {
        DetectHoverGameObject();
    }


    public Material DetectHoverGameObject()
    {

        Vector2 hitPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (Vector2.Distance(hitPos, transform.position) > maxRange)
        {
            ExitMaterial(lastMaterial);
            return null;
        }

        RaycastHit2D hit = Physics2D.Raycast(hitPos, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent(out Material material) && hit.collider.gameObject.layer != LayerMask.NameToLayer("CarriedMaterial"))
            {

                if (lastMaterial = null)
                {
                    EnterMaterial(material);
                    gate = true;
                }

                if (CheckIfLastMaterialIsEqualToCurrentlyHoveredOne(material))
                {
                    ExitMaterial(lastMaterial);
                    return null;
                }

                EnterMaterial(material);
                gate = true;
            }
        }
        else
        {
            if (gate)
            {
                gate = false;
                ExitMaterial(lastMaterial);
            }
            return null;
        }

        return lastMaterial;
    }

    bool CheckIfLastMaterialIsEqualToCurrentlyHoveredOne(Material material)
    {
        if (lastMaterial != null)
            return lastMaterial.Equals(material);
        else
            return false;

    }

    void EnterMaterial(Material material)
    {
        if (_equipItem.currentMaterial != null) _materialProjection.projection.CheckIfMouseHovers(1);
        lastMaterial = material;
        material.materialState = MaterialState.Possible;
        currentlyHoveredMaterial = lastMaterial;
    }

    void ExitMaterial(Material material)
    {
        if (_equipItem.currentMaterial != null) _materialProjection.projection.CheckIfMouseHovers(0);
        currentlyHoveredMaterial = null;
        if (material != null) material.materialState = MaterialState.Normal;
    }
}


