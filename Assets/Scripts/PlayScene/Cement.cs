using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MaterialPoint
{
    public Material material;
    public Vector2 fixedPosition;
}

public class Cement : MonoBehaviour
{
    [SerializeField]
    private float maxConnectionDistance = 0.1f;

    List<MaterialPoint> materialsWithinRange = new List<MaterialPoint>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Material material))
        {
            materialsWithinRange.Add(new MaterialPoint { material = material, fixedPosition = collision.ClosestPoint(material.transform.position) });
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Material material))
        {
            materialsWithinRange.Remove(materialsWithinRange.Where(x => x.material.gameObject.GetInstanceID().Equals(collision.gameObject.GetInstanceID())).FirstOrDefault());
        }
    }

    void UpdateCanFixMaterialssTogether()
    {
        Debug.Log(materialsWithinRange.Count);
    }

    public void FixSeveralMaterialsTogether(List<Material> materials)
    {

    }
}
