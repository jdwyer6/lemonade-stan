using Unity.VisualScripting;
using UnityEngine;

public class Mode_Hand : MonoBehaviour
{
    private int currentMode;
    private RaycastHelper raycastHelper;
    public LayerMask layerMask;

    void Start()
    {
        currentMode = GetComponent<ModeSelector>().currentMode;
        raycastHelper = GetComponent<RaycastHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMode != 0) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject hitObject = raycastHelper.GetObject(layerMask);

            if (hitObject.GetComponent<InventoryItemData>() != null)
            {
                InventoryItemData itemData = hitObject.GetComponent<InventoryItemData>();
                string name = itemData.item.itemName;
                GetComponent<Inventory>().CollectItem(name, hitObject.gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (currentMode != 0) return;
        
        if (other.GetComponent<InventoryItemData>() != null)
        {
            InventoryItemData itemData = other.GetComponent<InventoryItemData>();
            if (itemData.item.clickToCollect) return;
            string name = itemData.item.itemName;
            GetComponent<Inventory>().CollectItem(name, other.gameObject);
        }
    }

}