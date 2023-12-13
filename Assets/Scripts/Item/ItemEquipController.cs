using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemEquipController : MonoBehaviour
{
    public CanvasGroup equipPopUp;
    public CanvasGroup un_equipPopUp;
    public EquipPopUpController equipPopUpController;
    public Item test;

    public void Awake()
    {
        equipPopUpController = FindObjectOfType<EquipPopUpController>();
    }

    public void CancelButton()
    {
        InVisible();
    }

    public void ConfirmButton()
    {
        if (equipPopUpController.currentItem != null)
        {
            equipPopUpController.currentItem.ToggleEquip();
            InVisible();
        }
    }

    public void InVisible()
    {
        equipPopUp.alpha = 0.0f;
        equipPopUp.blocksRaycasts = false;

        un_equipPopUp.alpha = 0.0f;
        un_equipPopUp.blocksRaycasts = false;
    }
}
