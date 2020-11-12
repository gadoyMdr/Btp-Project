using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public class Layer
{
    public string layerName;
    public Color color;
    public int layer;

    public static Layer firstPlan { get => new Layer("FirstPlan", Color.white, 3); }

    public static Layer secondPlan { get => new Layer("SecondPlan", new Color(133,133,133,1), 2); }

    public Layer(string layerName, Color color, int layer)
    {
        this.layerName = layerName;
        this.color = color;
        this.layer = layer;
    }
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Hover))]
public class Material : MonoBehaviour
{
    [SerializeField]
    private Sprite inGameSprite;

    public Sprite shopSprite;

    public SpriteRenderer _spriteRenderer;

    [HideInInspector]
    public Rigidbody2D _rigidbody;

    public float price;

    //used so we don't pick up the item when it's already picked up
    public bool isPickedUp = false;

    private Hover _hover;


    private MaterialState MaterialState;
    public MaterialState materialState
    {
        get => MaterialState; 
        set
        {
            MaterialState = value;
            UpdateState();
        }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _spriteRenderer.sprite = inGameSprite;
    }
    

    /// <summary>
    /// Change the color to green if true or red if false and to normal if not hovered
    /// true = material in range
    /// </summary>
    /// <param name="value"></param>
    /// 

    public void ApplyLayer(Layer layer)
    {
        gameObject.layer = LayerMask.NameToLayer(layer.layerName);
        _spriteRenderer.color = layer.color;
        _spriteRenderer.sortingOrder = layer.layer;
    }

    void UpdateState()
    {
        _spriteRenderer.color = materialState.color;
    }

}
