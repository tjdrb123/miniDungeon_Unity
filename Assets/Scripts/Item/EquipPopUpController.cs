using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipPopUpController : MonoBehaviour
{
    public CanvasGroup equipPopUp;
    public CanvasGroup un_equipPopUp;
    public ItemManagement itemManagement;

    public Item currentItem;
    protected string buttonName;
    
    public void ClickItem()
    {
        buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        Item item = itemManagement.Items.Find(i => i.itemName == buttonName);
        if (item != null)
        {
            currentItem = item;
            if (item.isEquip)
            {
                equipPopUp.alpha = 0f;
                equipPopUp.blocksRaycasts = false;

                un_equipPopUp.alpha = 1.0f;
                un_equipPopUp.blocksRaycasts = true;
            }
            else
            {
                equipPopUp.alpha = 1.0f;
                equipPopUp.blocksRaycasts = true;

                un_equipPopUp.alpha = 0f;
                un_equipPopUp.blocksRaycasts = false;
            }
        }
    }
}

