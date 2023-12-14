using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    weapon,
    armor,
}

[CreateAssetMenu(fileName = "ItemData_", menuName = "Data/ItemData", order =1)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int price;
    public bool isEquiped;
    public Sprite image;
    public ItemType type;
}