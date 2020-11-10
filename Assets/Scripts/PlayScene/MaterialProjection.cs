using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
[RequireComponent(typeof(GameObjectHoverDetection))]
[RequireComponent(typeof(HoverMaterial))]
public class MaterialProjection : MonoBehaviour
{
   
    public Projection projection;
    
    [SerializeField]
    private float range = 5f;

    private HoverMaterial _hoverMaterial;
    private GameObjectHoverDetection _hoverDetection;
    private EquipItem _equipItem;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
        _hoverMaterial = GetComponent<HoverMaterial>();
        _hoverDetection = GetComponent<GameObjectHoverDetection>();
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
                projection.ToggleProjection(true);
                SetProjectionPoint();
            }
            else
            {
                projection.ToggleProjection(false);
            }

        }
        else
        {
            projection.ToggleProjection(_hoverMaterial.currentlyHoveredMaterial == null);
        }
        
        

    }

    void SetProjectionPoint()
    {
        Vector2 worldPos;
        _hoverDetection.DetectHoverGameObject(out worldPos);
        projection.transform.rotation = _equipItem.currentMaterial.transform.rotation;
        projection.transform.position = worldPos;

    }

    void RemoveProjection()
    {
        projection.DestroyProjection();
    }

    void SetProjection()
    {
        projection.CreateProjection(_equipItem.currentMaterial);
        projection.transform.localScale = _equipItem.currentMaterial.transform.localScale;
    }
}
