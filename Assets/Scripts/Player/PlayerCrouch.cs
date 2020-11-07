using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouch : MonoBehaviour
{
    private bool IsCrouched;
    public bool isCrouched
    {
        get => IsCrouched;
        set
        {
            IsCrouched = value;
            ToggleCrouch(IsCrouched);
        }
    }

    void ToggleCrouch(bool value)
    {
        if (value) Crouch();
        else DeCrouch();
    }

    void Crouch()
    {

    }

    void DeCrouch()
    {

    }

}
