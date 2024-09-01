using UnityEngine;

public class RaycastHelper : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 direction;
    public float rayDistance = 10f;

    void Update()
    {
        origin = Camera.main.transform.position;
        direction = Camera.main.transform.forward;
    }

    public bool PerformRaycast(out RaycastHit hit, LayerMask layerMask)
    {
        return Physics.Raycast(origin, direction, out hit, rayDistance, layerMask);
    }

    public string GetTag(LayerMask layerMask)
    {
        RaycastHit hit;
        if (PerformRaycast(out hit, layerMask))
        {
            return hit.collider.tag;
        }
        return null;
    }

    public int GetLayer(LayerMask layerMask)
    {
        RaycastHit hit;
        if (PerformRaycast(out hit, layerMask))
        {
            return hit.collider.gameObject.layer;
        }
        return -1; // Return -1 if no hit
    }
    
    public GameObject GetObject(LayerMask layerMask)
    {
        RaycastHit hit;
        if (PerformRaycast(out hit, layerMask))
        {
            return hit.collider.gameObject;
        }
        return null; // Return null if no hit
    }
}