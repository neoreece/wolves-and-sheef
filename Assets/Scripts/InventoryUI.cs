using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Displays the inventory object items to the user.
/// Manages logic pertaining to the synchronization of the inventory it is
/// displaying.
/// </summary>
public class InventoryUI : MonoBehaviour
{
    /// <summary>
    /// Inventory this InvenoryUI is displaying.
    /// </summary>
    public Inventory inventory;

    /// <summary>
    /// The ItemUI that will be used to display all items in the inventory.
    /// This itemUIPrefab may be a clickable sprite, or a text button.
    /// </summary>
    public ItemUI itemUIPrefab;

    /// <summary>
    /// The Transform of the UI container used to store this InventoryUI script.
    /// </summary>
    public Transform inventoryUIContent;

    // Start is called before the first frame update
    void Start()
    {
        if (inventory) {
            Display(inventory);
        }
    }

    /// <summary>
    /// Displays an ItemUI for every item in this inventory.
    /// Sets this InventoryUI inventory to the displayed inventory.
    /// </summary>
    public virtual void Display(Inventory inventory)
    {
        Debug.Log("DEBUG: InventoryUI.Display()");
        this.inventory = inventory;
        Debug.Log("DEBUG: Updated this inventory");
        Refresh();
    }

    /// <summary>
    /// Updates the item listing presented to the user.
    /// </summary>
    public virtual void Refresh()
    {
        Debug.Log("DEBUG: InventoryUI.Refresh()");
        Debug.Log("DEBUG: Destroying all content in this InventoryUI");
        foreach (Transform itemUI in inventoryUIContent) { // TODO: perhaps rename itemUI to content... or t...
            Destroy(itemUI.gameObject);
        }
        Debug.Log("DEBUG: Generating ItemUI for each inventory item in this InventoryUI");
        foreach (Item item in inventory.items) {
            ItemUI ui = ItemUI.Instantiate(itemUIPrefab, inventoryUIContent); // TODO: may need to add a public Transform content to this class and instantiation
            ui.onClicked.AddListener(ItemUIClick);
            ui.Display(item);
        }
    }

    /// <summary>
    ///  The ItemUIEvent onClick responder.
    /// </summary>
    public virtual void ItemUIClick(ItemUI itemUI)
    {
        Debug.Log("Destorying Thee!!!");
        Destroy(itemUI.gameObject);
    }
}
