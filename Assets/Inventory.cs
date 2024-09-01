using UnityEngine;
using System.Collections.Generic;


public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> items = new Dictionary<string, int>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectItem(string itemName, GameObject collectedObject)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName]++;
        }
        else
        {
            items[itemName] = 1;
        }

        Destroy(collectedObject);

        Debug.Log($"{itemName} collected! You now have {items[itemName]} {itemName}(s).");
    }
    
    public int GetItemQuantity(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            return items[itemName];
        }
        else
        {
            return 0; // Return 0 if the item doesn't exist in the inventory
        }
    }
}
