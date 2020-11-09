using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EquipItem))]
public class PlaceMaterial : MonoBehaviour
{
    private EquipItem _equipItem;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
    }

    public void PlaceMaterialFunction(Material materialToPlace, Vector3 pos, Quaternion rot)
    {
        _equipItem.UnEquip();
        materialToPlace.transform.SetParent(null);
        materialToPlace.transform.position = pos;
        materialToPlace.transform.rotation = rot;
    }
}
