using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public class Layer
{
    public string layerName;
    public Color colorSet;
    public Color selectedColor;
    public int layer;

    public static Layer firstPlan { get => new Layer("FirstPlan", Color.white, Color.green, 3); }

    public static Layer secondPlan { get => new Layer("SecondPlan", new Color(0.5f,0.5f,0.5f,1), new Color(0f, 0.5f, 0f, 1f), 2); }

    public Layer(string layerName, Color colorSet, Color selectedColor, int layer)
    {
        this.layerName = layerName;
        this.colorSet = colorSet;
        this.selectedColor = selectedColor;
        this.layer = layer;
    }
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Hover))]
public class Material : MonoBehaviour
{
    

    public Sprite shopSprite;

    public float price;

    //used so we don't pick up the item when it's already picked up
    public bool isPickedUp = false;

    public SpriteRenderer _spriteRenderer;

    [SerializeField]
    private Sprite inGameSprite;

    [HideInInspector]
    public Rigidbody2D _rigidbody;

    [HideInInspector]
    public Layer layer;

    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _spriteRenderer.sprite = inGameSprite;
        layer = Layer.firstPlan;
    }
    

    /// <summary>
    /// Change the color to green if true or red if false and to normal if not hovered
    /// true = material in range
    /// </summary>
    /// <param name="value"></param>
    /// 

    public void ApplyLayer(Layer layer)
    {
        this.layer = layer; 
        gameObject.layer = LayerMask.NameToLayer(layer.layerName);
        _spriteRenderer.color = layer.colorSet;
        _spriteRenderer.sortingOrder = layer.layer;
    }

}
