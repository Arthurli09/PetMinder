using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseInventoryButtonControl : MonoBehaviour
{
    // Inventory Panels
    public GameObject inventoryPanel;

    public void OpenInventory()
    {
        inventoryPanel.SetActive(true);
    }

    public void CloseInventory()
    {
        inventoryPanel.SetActive(false);
    }

}
