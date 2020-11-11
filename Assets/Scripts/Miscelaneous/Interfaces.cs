using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHoverable
{

}

public interface IClickable
{

}

public interface Iinteractable
{
    Transform handleTransform { get; set; }
    Player player { get; set; }
    float radiusRange { get; set; }
    bool canBeInteractedWith { get; set; }
    bool isInteractedWith { get; set; }
    void CheckIfPlayerWithingRange();
}

public interface IGrabable : Iinteractable
{
    Rigidbody2D rigidbody2D { get; set; }
}

public interface IActionable : Iinteractable
{
    void Trigger();
    void TurnOff();
}
