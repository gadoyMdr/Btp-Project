using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EquipItem))]
[RequireComponent(typeof(HoverMaterial))]
public class MaterialProjection : MonoBehaviour
{
   
    public Projection projection;
    
    [SerializeField]
    private float range = 5f;

    private HoverMaterial _hoverMaterial;
    private EquipItem _equipItem;
    private Vector2 worldCursorPos = Vector2.zero;

    private void Awake()
    {
        _equipItem = GetComponent<EquipItem>();
        _hoverMaterial = GetComponent<HoverMaterial>();
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
        worldCursorPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (_equipItem.currentMaterial != null)
        {
            if(Vector2.Distance(transform.position, worldCursorPos) < range)
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
        Vector2 worldPos = worldCursorPos;

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
        projection.UpdateIsOverlaping(0);
        projection.transform.localScale = _equipItem.currentMaterial.transform.localScale;
    }
}
