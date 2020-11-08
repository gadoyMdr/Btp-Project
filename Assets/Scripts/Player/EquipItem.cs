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
    [Range(1, 20)]
    private float dropForce;

    private PlayerMove _playerMove;

    private void Awake()
    {
        _playerMove = GetComponent<PlayerMove>();
    }

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
        if (currentMaterial == null) ActuallyEquip(material);
    }

    /// <summary>
    /// Switch materials
    /// </summary>
    /// <param name="materialToEquip"></param>
    public void SwitchMaterial(Material materialToEquip)
    {
        DropCurrentMaterial();
        ActuallyEquip(materialToEquip);
    }



    void ActuallyEquip(Material materialToEquip)
    {   
        currentMaterial = materialToEquip;

        currentMaterial.SwitchToPickedUp();

        PlaceMaterial(materialToEquip);
    }

    void DropCurrentMaterial()
    {
        if(currentMaterial != null)
        {
            currentMaterial.transform.SetParent(null);
            currentMaterial._rigidbody.AddForce(new Vector2(_playerMove.direction, 1) * dropForce, ForceMode2D.Impulse);
            currentMaterial = null;
            currentMaterial.SwitchToDropped();
        }
        
    }

    void PlaceMaterial(Material materialToPlace)
    {
        materialToPlace.transform.rotation = Quaternion.identity;
        materialToPlace.transform.SetParent(carryPoint);
    }

    void SetMaterialPos()
    {
        if (currentMaterial != null) currentMaterial.transform.position = carryPoint.transform.position;
    }

    
}
