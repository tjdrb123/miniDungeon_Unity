using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpEquip : MonoBehaviour
{
    [SerializeField] private Text popUpText;
    [SerializeField] private Button confirmBtn;

    public void PopUpSetting(ItemSlot slot)
    {
        if(slot.itemData.isEquiped)
        {
            popUpText.text = "장착을 해제 하시겠습니까?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = false;
                slot.ChangeEquip();
            });
        }
        else
        {
            popUpText.text = "장착 하시겠습니까?";
            confirmBtn.onClick.AddListener(() => {
                slot.itemData.isEquiped = true;
                slot.ChangeEquip();
            });
        }
    }
}
