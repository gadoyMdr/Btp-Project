using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
[RequireComponent(typeof(GameObjectHoverDetection))]
public class MaterialProjection : MonoBehaviour
{
   
    public Transform projectionPoint;
    public bool canPlaceMaterial = false;

    [SerializeField]
    private float range = 5f;

    private GameObjectHoverDetection _hoverDetection;
    private EquipItem _equipItem;
    private SpriteRenderer projectionSpriteRenderer;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
        _hoverDetection = GetComponent<GameObjectHoverDetection>();

        projectionSpriteRenderer = projectionPoint.GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _equipItem.EquipEvent += SetProjection;
        _equipItem.UnEquipEvent += RemoveProjection;
    }

    private void OnDisable()
    {
        _equipItem.EquipEvent -= SetProjection;
        _equipItem.UnEquipEvent -= RemoveProjection;
    }

    private void Update()
    {
        if(_equipItem.currentMaterial != null)
        {
            if(Vector2.Distance(transform.position, Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())) < range)
            {
                canPlaceMaterial = true;
                SetProjectionPoint();
            }
            else
            {
                canPlaceMaterial = false;
            }
            projectionSpriteRenderer.enabled = canPlaceMaterial;
        }
        
    }

    void SetProjectionPoint()
    {
        Vector2 worldPos;
        _hoverDetection.DetectHoverGameObject(out worldPos);
        projectionPoint.rotation = _equipItem.currentMaterial.transform.rotation;
        projectionPoint.position = worldPos;

    }

    void RemoveProjection()
    {
        projectionSpriteRenderer.sprite = null;
        canPlaceMaterial = false;
    }

    void SetProjection()
    {
        canPlaceMaterial = true;
        projectionSpriteRenderer.sprite = Instantiate(_equipItem.currentMaterial._spriteRenderer.sprite, projectionPoint);
        projectionPoint.localScale = _equipItem.currentMaterial.transform.localScale;
        
    }
}
