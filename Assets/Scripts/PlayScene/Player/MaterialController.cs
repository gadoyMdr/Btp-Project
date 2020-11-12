using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(EquipItem))]
public class MaterialController : MonoBehaviour
{
    public void RotateCurrentMaterial(float x)
    {
        RotateMaterials material = FindObjectsOfType<RotateMaterials>().
            Where(x => x.GetComponent<Interact>() != null).
            Where(x => x.GetComponent<Interact>().isInteractedWith).
            FirstOrDefault();

        if(material != null)
            material.Rotate(x);

    }
}
