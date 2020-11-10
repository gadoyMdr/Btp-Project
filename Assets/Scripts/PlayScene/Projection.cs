using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Projection : MonoBehaviour
{
    [SerializeField]
    private HoverMaterial hoverMaterial;


    public bool isProjectionOverlapping;

    BoxCollider2D boxCollider;

    public SpriteRenderer _spriteRenderer {get;set;}

    private List<Collider2D> allColliders = new List<Collider2D>();

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        allColliders.Add(collision);
        
        UpdateIsOverlaping(0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        allColliders.Remove(collision);
        UpdateIsOverlaping(0);
    }

    public void CheckIfMouseHovers(int max)
    {
        if (allColliders.Count > 0)
            //Get the last material that entered the projection
            if (allColliders[allColliders.Count - 1].gameObject.TryGetComponent(out Material material))
                //If the last material is the material we're hovering
                if (material.Equals(hoverMaterial.currentlyHoveredMaterial))
                    UpdateIsOverlaping(max);
                
    }


    public void UpdateIsOverlaping(int count)
    {

        if(allColliders.Count > count)
        {
            _spriteRenderer.color = new Color(255, 0, 0, 0.4f);
            isProjectionOverlapping = true;
        }
        else
        {
            _spriteRenderer.color = new Color(0, 255, 0, 0.4f);
            isProjectionOverlapping = false;
        }
    }

    public void CreateProjection(Material material)
    {
        _spriteRenderer.sprite = material._spriteRenderer.sprite;

        boxCollider = (BoxCollider2D) gameObject.AddComponent(typeof(BoxCollider2D));
        boxCollider.size = material.GetComponent<BoxCollider2D>().size;

        boxCollider.isTrigger = true;
    }

    public void DestroyProjection()
    {
        _spriteRenderer.sprite = null;
        Destroy(boxCollider);
    }

    public void ToggleProjection(bool value)
    {
        _spriteRenderer.enabled = value;
    }

}
