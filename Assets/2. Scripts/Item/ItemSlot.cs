using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [HideInInspector] public ItemData itemData;
    public PopUpEquip popUpEquip;
    public Image itemImage;
    public GameObject equipMark;

    public void Init(ItemData data)
    {
        itemData = data;
        itemImage.sprite = data.image;
        itemImage.enabled = true;

        ToggleEquip();
    }

    public void ToggleEquip()
    {
        if(itemData.isEquiped)
        {
            equipMark.SetActive(true);
        }
        else
        {
            equipMark.SetActive(false);
        }
    }

    public void PopUp()
    {
        if(itemData != null) popUpEquip.PopUpSetting(this);
    }
}
