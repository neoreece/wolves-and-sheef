using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// Custom ItemUIEvent that passes an argument of ItemUI, or itself.
/// </summary>
[System.Serializable]
public class ItemUIEvent : UnityEvent<ItemUI> {}

/// <summary>
/// The display of an item object.
/// Triggers events to interested listeners when it is clicked.
/// </summary>
public class ItemUI : MonoBehaviour
{
    /// <summary>
    /// The item instance this UI is displaying.
    /// </summary>
    public Item item;

    /// <summary>
    /// The name of the gameObject holding this item's instance.
    /// The chosen display is Text, however it could be a sprite, or other
    /// presentation.
    /// </summary>
    public Text itemName;

    /// <summary>
    /// TODO: this summary
    /// </summary>
    public ItemUIEvent onClicked;

    // Start is called before the first frame update
    void Start()
    {
        if (item) {
            Display(item);
        } 
    }

    /// <summary>
    /// Update this ItemUI's itemName field with the input item's name.
    /// Sets this ItemUI's item to the input Item.
    /// </summary>
    public virtual void Display(Item item)
    {
        Debug.Log("Displaying the item " + item.name);
        this.item = item;
        itemName.text = item.name;
    }

    /// <summary>
    /// Raises this ItemUIEvent clicked.
    /// </summary>
    public virtual void Click()
    {
        Debug.Log("ItemUI was clicked");
        onClicked.Invoke(this);
    }

}
