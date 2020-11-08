using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EquipItem))]
public class MaterialController : MonoBehaviour
{

    private EquipItem _equipItem;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
    }

    public void RotateMaterial(float x)
    {
        if (_equipItem.currentMaterial != null)
        {
            if (_equipItem.currentMaterial.TryGetComponent(out RotateMaterials rotateMaterials))
                rotateMaterials.Rotate(x);
        }
    }
}
