using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_", menuName = "Data/ItemData", order =1)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int price;
    public bool isEquiped;
    public Sprite image;
}
