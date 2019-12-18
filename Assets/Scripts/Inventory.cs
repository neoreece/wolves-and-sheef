using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The root Inventory class.
/// Contains a list of instantiated items and may perform actiosn to manage
/// these items.
/// </summary>
/// <remarks>
/// The Inventory class may add and remove items.
/// </remarks>
public class Inventory : MonoBehaviour
{
    /// <summary>
    /// The instances of item in this inventory.
    /// </summary>
    public List<Item> items;

    // Start is called before the first frame update
    void Start()
    {
        InventoryRestriction[] restrictions = GetComponentsInChildren<InventoryRestriction>(true);
        foreach (InventoryRestriction r in restrictions) {
            r.EnforceRestriction(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
