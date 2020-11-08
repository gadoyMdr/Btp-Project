using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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

    private void Awake() => _equipItem = GetComponent<EquipItem>();
    

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
        StartCoroutine(CheckForItemCoroutine());
    }

    void CheckNearestItemAround()
    {

        Material nearestMaterial = Physics2D.OverlapCircleAll(transform.position, autoPickUpRange) //Find colliders within range
            .OrderByDescending(t => Vector3.Distance(t.transform.position, transform.position)) // Order
                           .FirstOrDefault() // Pick the first
                           .gameObject //Grab GameObject
                           .GetComponent<Material>(); //Grab its material

        if (nearestMaterial != null && !nearestMaterial.isPickedUp) _equipItem.TryEquip(nearestMaterial);

    }

}
