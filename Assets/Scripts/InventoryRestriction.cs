using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Limits the amount and type of items in an inventory.
/// Extensions of this interface perform specific restriction operations.
/// </summary>
public interface InventoryRestriction
{
    /// <summary>
    /// Enforces the restriction, removing and restricting items as needed.
    /// </summary>
    void EnforceRestriction(Inventory inventory);
}
