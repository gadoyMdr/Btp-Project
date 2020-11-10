using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
public class HoverMaterial : MonoBehaviour
{
    public Action<int> MouseChangingMaterialEvent;

    [SerializeField]
    private float checkDelay = 0.1f;

    [SerializeField]
    private float maxRange = 5;

    [HideInInspector]
    public Material currentlyHoveredMaterial;

    private GameObjectHoverDetection hoverDetection;
    private EquipItem equipItem;
    private void Awake()
    {
        hoverDetection = FindObjectOfType<GameObjectHoverDetection>();
        equipItem = GetComponent<EquipItem>();
    }

    void Start()
    {
        StartCoroutine(CheckForItemCoroutine());
    }

    //TODO : restructure that thing
    void CheckIfMouseHoverMaterial()
    {
        Material hoveredMaterial = hoverDetection.DetectHoverGameObject(out _);

        //If we're currently hovering a material
        if (hoveredMaterial != null)
        {

            //If we are carrying a material
            if (equipItem.currentMaterial != null)
            {
                //If we're not hovering the material we're carrying
                if (!equipItem.currentMaterial.Equals(hoveredMaterial))
                {
                    hoveredMaterial.SetToHovered(Vector2.Distance(hoveredMaterial.transform.position, transform.position) < maxRange);
                    MouseChangingMaterialEvent?.Invoke(1);
                    currentlyHoveredMaterial = hoveredMaterial;
                }

            }
            else
            {
                hoveredMaterial.SetToHovered(Vector2.Distance(hoveredMaterial.transform.position, transform.position) < maxRange);
                MouseChangingMaterialEvent?.Invoke(1);
                currentlyHoveredMaterial = hoveredMaterial;
            }
                
        }
        else
        {
            FindObjectsOfType<Material>().ToList().ForEach(x => x.SetToHovered(null));
            MouseChangingMaterialEvent?.Invoke(0);
            currentlyHoveredMaterial = null;
        }

    }

    IEnumerator CheckForItemCoroutine()
    {
        yield return new WaitForSeconds(checkDelay);
        CheckIfMouseHoverMaterial();
        StartCoroutine(CheckForItemCoroutine());
    }
}
