using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
[RequireComponent(typeof(PlaceMaterial))]
public class EquipItem : MonoBehaviour
{
    public Action EquipEvent;
    public Action UnEquipEvent;

    public Material currentMaterial { get; private set; }

    [SerializeField]
    private Transform carryPoint;

    [SerializeField]
    private Transform dropPoint;

    [SerializeField]
    [Range(1, 20)]
    private float dropForce;

    private PlaceMaterial _placeMaterial;

    private void Awake()
    {
        _placeMaterial = GetComponent<PlaceMaterial>();
    }

    private void Update()
    {
        SetMaterialPos();
    }

    /// <summary>
    /// Equip 'material' if there isn't any current
    /// </summary>
    /// <param name="materialToEquip">Material to Equip</param>
    public bool TryEquip(Material material)
    {
        if (currentMaterial == null && !material.isPickedUp) ActuallyEquip(material);
        return currentMaterial == null && !material.isPickedUp;
    }

    public void UnEquip()
    {
        UnEquipEvent?.Invoke();
        currentMaterial.SwitchToDropped();
        currentMaterial.gameObject.layer = LayerMask.NameToLayer("Material");
        currentMaterial = null;
    }

    /// <summary>
    /// Switch materials
    /// </summary>
    /// <param name="materialToEquip"></param>
    public void SwitchMaterial(Material materialToEquip)
    {
        if (materialToEquip.canBePickedUp)
        {
            _placeMaterial.PlaceMaterialFunction(currentMaterial, materialToEquip.transform.position, currentMaterial.transform.rotation);
            ActuallyEquip(materialToEquip);
        }
        
    }


    //Equip
    void ActuallyEquip(Material materialToEquip)
    {
        materialToEquip.gameObject.layer = LayerMask.NameToLayer("CarriedMaterial");

        currentMaterial = materialToEquip;

        currentMaterial.SwitchToPickedUp();

        PlaceMaterial(materialToEquip);

        EquipEvent?.Invoke();
    }

    //Throw away current material
    void DropCurrentMaterial()
    {
        if(currentMaterial != null)
        {
            currentMaterial.transform.SetParent(null);
            UnEquipEvent?.Invoke();
            currentMaterial.transform.position = dropPoint.position;
            currentMaterial.SwitchToDropped();
            currentMaterial = null;
        }
        
    }

    void PlaceMaterial(Material materialToPlace)
    {
        materialToPlace.transform.rotation = Quaternion.identity;
        materialToPlace.transform.SetParent(carryPoint);
    }

    //Make the material follow the player
    void SetMaterialPos()
    {
        if (currentMaterial != null) currentMaterial.transform.position = carryPoint.position;
    }

    
}
