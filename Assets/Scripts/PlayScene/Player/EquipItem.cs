using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
public class EquipItem : MonoBehaviour
{
    [HideInInspector]
    public Material currentMaterial;

    [SerializeField]
    private Transform carryPoint;

    [SerializeField]
    private Transform dropPoint;

    [SerializeField]
    [Range(1, 20)]
    private float dropForce;

    private void Update()
    {
        SetMaterialPos();
    }

    /// <summary>
    /// Equip 'material' if there isn't any current
    /// </summary>
    /// <param name="materialToEquip">Material to Equip</param>
    public void TryEquip(Material material)
    {
        if(PhotonNetwork.IsMasterClient)
            if (currentMaterial == null && !material.isPickedUp) ActuallyEquip(material);
    }

    /// <summary>
    /// Switch materials
    /// </summary>
    /// <param name="materialToEquip"></param>
    public void SwitchMaterial(Material materialToEquip)
    {
        if (materialToEquip.canBePickedUp && PhotonNetwork.IsMasterClient)
        {
            DropCurrentMaterial();
            ActuallyEquip(materialToEquip);
        }
        
    }


    //Equip
    void ActuallyEquip(Material materialToEquip)
    {   
        currentMaterial = materialToEquip;

        currentMaterial.SwitchToPickedUp();

        PlaceMaterial(materialToEquip);
    }

    //Throw away current material
    void DropCurrentMaterial()
    {
        if(currentMaterial != null)
        {
            currentMaterial.transform.SetParent(null);
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
