using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomProperties
{
    public string propertyName;

    public static CustomProperties playerHost { get => new CustomProperties("Player Host"); }

    private CustomProperties(string propertyName)
    {
        this.propertyName = propertyName;
    }
}
