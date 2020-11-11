using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheelBarrow : MonoBehaviour, IGrabable
{
    [SerializeField]
    private Transform HandleTransform;
    public Transform handleTransform { get => HandleTransform; set => HandleTransform = value; }

    [SerializeField]
    private float RadiusRange;
    public float radiusRange { get => RadiusRange; set => RadiusRange = value; }

    [SerializeField]
    private Rigidbody2D Rigidbody2D;
    public new Rigidbody2D rigidbody2D { get => Rigidbody2D; set => Rigidbody2D = value; }

    [SerializeField]
    private PopupText popupTextPrefab;

    public Player player { get; set; }
    public bool canBeInteractedWith { get; set; }

    private bool IsInteractedWith;
    public bool isInteractedWith 
    { 
        get => IsInteractedWith;
        set 
        { 
            IsInteractedWith = value;
            if (value) TurnOff();
            else Trigger();
        }
    }
    

    private bool gatePlayerInRange = false;
    private bool tempPlayerInRange = false;

    private PopupText popupTextInstance;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        CheckIfPlayerWithingRange();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 255, 255, 0.2f);
        Gizmos.DrawSphere(handleTransform.position, radiusRange);
    }

    public void CheckIfPlayerWithingRange()
    {
        if (Vector2.Distance(player.transform.position, handleTransform.position) < radiusRange)
            gatePlayerInRange = true;
        else
            gatePlayerInRange = false;


        if (gatePlayerInRange != tempPlayerInRange)
        {
            if (gatePlayerInRange) Trigger();
            else TurnOff();
            tempPlayerInRange = gatePlayerInRange;
        }
    }

    public void Trigger()
    {
        canBeInteractedWith = true;
        popupTextInstance = Instantiate(popupTextPrefab, GameObject.Find("WorldSpaceCanvas").transform);
        popupTextInstance.ChangeText("Press E to pull");
        popupTextInstance.transformToFollow = handleTransform;
    }

    public void TurnOff()
    {
        canBeInteractedWith = false;

        if(popupTextInstance != null)
            Destroy(popupTextInstance.gameObject);
    }
}
