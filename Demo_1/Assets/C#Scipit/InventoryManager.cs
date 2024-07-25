using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    private bool isInventoryOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.SetActive(false); // Start with the inventory panel closed
    }

    // Update is called once per frame
    public void ToggleInventory()
    {
        isInventoryOpen = !isInventoryOpen;
        inventoryPanel.SetActive(isInventoryOpen);
    }
}
