using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagement : MonoBehaviour
{
    public List<Item> Items { get; set; }

    public void Start()
    {
        Items = new List<Item>
        {
            new Item("Sword", false),
            new Item("Hammer", false),
            new Item("Bow", false)
        };
    }
}
