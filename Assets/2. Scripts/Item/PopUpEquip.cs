using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpEquip : MonoBehaviour
{
    [SerializeField] private Text popUpText;
    [SerializeField] private Button confirmBtn;
    [SerializeField] private Image itemImage;
    [SerializeField] private Text itemstat;
    private string itemTypeText;

    public void PopUpSetting(ItemSlot slot)
    {
        itemImage.sprite = slot.itemData.image;
        SetItemStatText(slot);

        if (slot.itemData.isEquiped)
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

    private void SetItemStatText(ItemSlot slot)
    {
        itemTypeText = slot.itemData.type == ItemType.armor ? "Defense" : "Attack";
        itemstat.text = itemTypeText + " + " + slot.itemData.itemStat.ToString();
    }
}
