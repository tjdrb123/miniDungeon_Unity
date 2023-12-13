using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemName;
    public bool isEquip;

    public Item(string itemName, bool isEquip)
    {
        this.itemName = itemName;
        this.isEquip = isEquip;
    }

    public void ToggleEquip()
    {
        isEquip = !isEquip;
    }
}