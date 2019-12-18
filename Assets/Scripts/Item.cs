using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Item class is responsible for the root logic of all items.
/// <summary/>
public class Item : MonoBehaviour
{
    protected const bool includeInactive = true;

    // Update is called once per frame
    void Update()
    {
       ItemMod[] attributes = GetComponentsInParent<ItemMod>(includeInactive);     
    }
}
