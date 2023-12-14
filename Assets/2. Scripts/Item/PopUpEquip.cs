using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class PopUpEquip : MonoBehaviour
{
    public Text popUpText;
    public Button confirmBtn;

    public void PopUpSetting(ItemSlot slot)
    {
        if(slot.itemData.isEquiped)
        {
            popUpText.text = "������ ���� �Ͻðڽ��ϱ�?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = false;
                slot.ToggleEquip();
            });
         
        }
        else
        {
            popUpText.text = "���� �Ͻðڽ��ϱ�?";
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = true;
                slot.ToggleEquip();
            });
        }
    }
}
