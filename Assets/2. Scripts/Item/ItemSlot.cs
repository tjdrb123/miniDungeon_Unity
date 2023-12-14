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
    public GameObject popEquipImage;
    public SpriteRenderer weaponSpriteRenderer;

    public void Init(ItemData data)
    {
        itemData = data;
        itemImage.sprite = data.image;
        itemImage.enabled = true;

        ChangeEquip();
    }

    public void ChangeEquip()
    {
        if (itemData.isEquiped)
        {
            equipMark.SetActive(true);
            Debug.Log(itemData.type + (int)ItemType.weapon);
            Debug.Log("test" + 0);
            if(itemData.type == ItemType.weapon)
                weaponSpriteRenderer.sprite = itemImage.sprite;
        }
        else
        {
            equipMark.SetActive(false);
            if (itemData.type == ItemType.weapon)
                weaponSpriteRenderer.sprite = null;
        }
    }

    public void PopUp()
    {
        if (itemImage.enabled == false)
            return;
        else
        popEquipImage.gameObject.SetActive(true);
        popUpEquip.PopUpSetting(this);
    } 
}
