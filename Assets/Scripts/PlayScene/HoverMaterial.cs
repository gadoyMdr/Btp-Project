using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class HoverMaterial : MonoBehaviour
{
    [SerializeField]
    private float checkDelay = 0.1f;

    [SerializeField]
    private float maxRange = 5;

    [HideInInspector]
    public Material currentlyHoveredMaterial;

    private GameObjectHoverDetection hoverDetection;

    private void Awake()
    {
        hoverDetection = FindObjectOfType<GameObjectHoverDetection>();
    }

    void Start()
    {
        StartCoroutine(CheckForItemCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO : restructure that thing
    void CheckIfMouseHoverMaterial()
    {
        Material hoveredMaterial = hoverDetection.DetectHoverGameObject(out _);

        if (hoveredMaterial != null)
        {
            hoveredMaterial.SetToHovered(Vector3.Distance(hoveredMaterial.transform.position, transform.position) < maxRange);

            currentlyHoveredMaterial = hoveredMaterial;
        }
        else
        {
            FindObjectsOfType<Material>().ToList().ForEach(x => x.SetToHovered(null));
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
