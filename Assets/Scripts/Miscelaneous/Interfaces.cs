using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface Iinteractable
{
    public Action<bool> CanBeInteractedWith { get; set; }
}

public interface IVisualWhenInteractedWith
{
    public Action<GameObject, bool> VisualTriggered { get; set; }
    void TriggerVisual(object[] parameters);
    void TurnOffVisual();
}

public interface IActionWhenInteractedWith
{
    public Action<GameObject, bool> ActionTriggerd { get; set; }
    void TriggerAction(object[] parameters);
    void TurnOffAction();
}

