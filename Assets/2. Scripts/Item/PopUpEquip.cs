using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpEquip : MonoBehaviour
{
    //public Sprite weaponSprite;
    public Text popUpText;
    public Button confirmBtn;
    public SpriteRenderer weaponSpriteRenderer;

    public void PopUpSetting(ItemSlot slot)
    {
        if(slot.itemData.isEquiped)
        {
            popUpText.text = "������ ���� �Ͻðڽ��ϱ�?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = false;
                slot.ChangeEquip();
            });
        }
        else
        {
            popUpText.text = "���� �Ͻðڽ��ϱ�?";
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = true;
                slot.ChangeEquip();
            });
        }
    }
}
