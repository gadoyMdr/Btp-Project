using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RangeDetection : MonoBehaviour, Iinteractable
{

    public Action<bool> CanBeInteractedWith { get; set; }

    [SerializeField]
    private float radiusRange;

    [SerializeField]
    private Transform detectionTransform;

    [SerializeField]
    private Transform transformToTrack;

    private bool IsTrackedObjectWithingRange;

    [HideInInspector]
    public bool isTrackedObjectWithingRange
    {
        get => IsTrackedObjectWithingRange;
        set
        {
            IsTrackedObjectWithingRange = value;
            CanBeInteractedWith?.Invoke(value);
        }
    }

    private bool gatePlayerInRange = false;
    private bool tempPlayerInRange = false;


    private void Update() => CheckIfPlayerWithingRange();

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 255, 255, 0.5f);
        Gizmos.DrawSphere(detectionTransform == null ? transform.position : detectionTransform.position, radiusRange);
    }

    public void CheckIfPlayerWithingRange()
    {
        if (Vector2.Distance(transformToTrack.position, detectionTransform == null? transform.position : detectionTransform.position) < radiusRange)
            gatePlayerInRange = true;
        else
            gatePlayerInRange = false;


        if (gatePlayerInRange != tempPlayerInRange)
        {
            if (gatePlayerInRange) isTrackedObjectWithingRange = true;
            else isTrackedObjectWithingRange = false;

            tempPlayerInRange = gatePlayerInRange;
        }
    }

}
