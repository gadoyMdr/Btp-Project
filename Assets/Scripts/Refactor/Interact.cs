using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Iinteractable))]
[RequireComponent(typeof(IVisualWhenInteractedWith))]
public class Interact : MonoBehaviour
{
    [SerializeField]
    private bool CanBeInteractedWith;
    public bool canBeInteractedWith { 
        get => CanBeInteractedWith;
        set
        {
            CanBeInteractedWith = value;
            if (value) iVisualWhenInteractedWith.TriggerVisual(new object[0]);
            else iVisualWhenInteractedWith.TurnOffVisual();
            
        }
    }

    [SerializeField]
    private bool IsInteractedWith;
    public bool isInteractedWith
    {
        get => IsInteractedWith;
        set
        {
            IsInteractedWith = value;
            if (value)
            {
                iVisualWhenInteractedWith.TurnOffVisual();

                if (iActionWhenInteractedWith.GetType().Equals(typeof(Grab)))
                    iActionWhenInteractedWith.TriggerAction(new object[] { GameObject.FindObjectOfType<Player>() });
                else
                    iActionWhenInteractedWith.TriggerAction(new object[0]);
            }
            else
            {
                if(canBeInteractedWith) iVisualWhenInteractedWith.TriggerVisual(new object[0]);
                else iVisualWhenInteractedWith.TurnOffVisual();

                iActionWhenInteractedWith.TurnOffAction();

            }
        }
    }

    [SerializeField]
    private bool hold;

    [SerializeField]
    private InputAction Action;
    public InputAction action
    {
        get => Action;
        set
        {
            Action = value;
        }

    }

    private Iinteractable iinteractable;
    private IVisualWhenInteractedWith iVisualWhenInteractedWith;
    private IActionWhenInteractedWith iActionWhenInteractedWith;

    private void Awake()
    {
        iVisualWhenInteractedWith = GetComponent<IVisualWhenInteractedWith>();
        iActionWhenInteractedWith = GetComponent<IActionWhenInteractedWith>();
        iinteractable = GetComponent<Iinteractable>();
    }

    private void Start()
    {
        iinteractable.CanBeInteractedWith += (bool value) => canBeInteractedWith = value;
        action.performed += _ => TryToInteract();
        action.canceled += _ => TryToDrop();
    }

    void TryToInteract()
    {
        if(canBeInteractedWith) isInteractedWith = true;
    }

    void TryToDrop()
    {
        if(IsInteractedWith) isInteractedWith = false;
    }

    private void Update()
    {
        if (hold && isInteractedWith)
            isInteractedWith = true;
    }

    private void OnEnable() => action.Enable();
    

    private void OnDisable() => action.Disable();
    
}
