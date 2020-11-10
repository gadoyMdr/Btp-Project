using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MaterialState
{
    public string name;
    public Color color;
    public bool canBePickedUp;
    public static MaterialState Impossible { get => new MaterialState("Impossible", new Color(255, 0, 0, 0.5f), false); }

    public static MaterialState Possible { get => new MaterialState("Possible", new Color(0, 255, 0, 0.5f), true); }

    public static MaterialState Normal { get => new MaterialState("Normal", new Color(255, 255, 255, 1f), false); }

    public static MaterialState Transparant { get => new MaterialState("Normal", new Color(255, 255, 255, 0.2f), false); }

    public MaterialState(string name, Color color, bool canBePickedUp)
    {
        this.name = name;
        this.color = color;
        this.canBePickedUp = canBePickedUp;
    }
}
