using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
public class PickUpItem : MonoBehaviour
{
    [SerializeField]
    private float maxRange;

    [SerializeField]
    private float autoPickUpRange;

    [SerializeField]
    private float checkDelay;

    private EquipItem _equipItem;
    private GameObjectHoverDetection hoverDetection;

    private void Awake()
    {
        hoverDetection = FindObjectOfType<GameObjectHoverDetection>();
        _equipItem = GetComponent<EquipItem>();
    }
    

    void Start() => StartCoroutine(CheckForItemCoroutine());
    

    
    //Draw sphere in inspector for the reach
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 255, 255, 0.5f);
        Gizmos.DrawSphere(transform.position, autoPickUpRange);
    }

    //Check for any item around every checkDelay seconds
    IEnumerator CheckForItemCoroutine()
    {
        yield return new WaitForSeconds(checkDelay);
        CheckNearestItemAround();
        CheckIfMouseHoverMaterial();
        StartCoroutine(CheckForItemCoroutine());
    }

    void CheckNearestItemAround()
    {

        Material nearestMaterial = Physics2D.OverlapCircleAll(transform.position, autoPickUpRange) //Find colliders within range
            .OrderByDescending(t => Vector3.Distance(t.transform.position, transform.position)) // Order
                           .FirstOrDefault() // Pick the first
                           .gameObject //Grab GameObject
                           .GetComponent<Material>(); //Grab its material

        if (nearestMaterial != null)
            if (_equipItem.TryEquip(nearestMaterial))
                ResetAllMaterials();

    }


    //TODO : restructure that thing
    void CheckIfMouseHoverMaterial()
    {
        Material hoveredMaterial = hoverDetection.DetectHoverGameObject();

        if (hoveredMaterial != null)
        {
            hoveredMaterial.SetToHovered(Vector3.Distance(hoveredMaterial.transform.position, transform.position) < maxRange);

            if (Mouse.current.leftButton.isPressed && hoveredMaterial.canBePickedUp)
                _equipItem.SwitchMaterial(hoveredMaterial);

        }
        else
            ResetAllMaterials();

    }

    //TODO : restructure that thing
    void ResetAllMaterials() => FindObjectsOfType<Material>().ToList().ForEach(x => x.SetToHovered(null));

}
