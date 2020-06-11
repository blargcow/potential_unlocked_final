﻿using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;
    
    private Item item;

    public void addItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void clearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
        
    }

    public void onRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    public void useItem()
    {
        if (item != null)
        {
            item.use();
        }
    }
    
    
    
    
}