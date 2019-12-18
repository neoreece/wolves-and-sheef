using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Allows only items in this WhiteList to be in the inventory.
/// </summary>
/// <remark>
/// Checks if any item in the inventory is not in the whitelist and removes it.
/// Prevents other non-whitelisted items from being added from the inventory.
/// </remark>
public class InventoryRestrictionWhiteList : MonoBehaviour, InventoryRestriction
{
    /// <summary>
    /// List of allowed inventory items.
    /// </summary>
    public List<Item> whiteList;

    /// <summary>
    /// Removes any restricted items from the inventory.
    /// </summary>
    public void EnforceRestriction(Inventory inventory)
    {
        foreach (Item item in inventory.items) {
            if (!isWhiteListed(item)) {
                Debug.Log("THAT IS NOT ALLOWED! DESTROYING THIS ITEM!!!");
                Destroy(item.gameObject);
            }
        }
    }

    /// <summary>
    /// Return true if item is in this white list.
    /// </summary>
    public bool isWhiteListed(Item item)
    {
        // Compare item to all items in whitelist.
        foreach (Item whiteListItem in whiteList) {
            if (item.Equals(whiteListItem)) {
                Debug.Log("DEBUG: " + item.name + " is whitelisted!");
                return true;
            }
            Debug.Log("DEBUG: Reached end of whitelist without finding a match.");
        }
        // Item was not found n the whitelist from the above search.
        Debug.Log("DEBUG: " + item.name + " is not whitelisted.");
        return false;
    }
}
