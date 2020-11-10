using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hover
{
    public string name;
    public Color color;

    public static Hover Impossible { get => new Hover("Impossible", new Color(255, 0, 0, 0.5f)); }

    public static Hover Possible { get => new Hover("Possible", new Color(0, 255, 0, 0.5f)); }

    public static Hover Normal { get => new Hover("Normal", new Color(255, 255, 255, 1f)); }

    public Hover(string name, Color color)
    {
        this.name = name;
        this.color = color;
    }
}
