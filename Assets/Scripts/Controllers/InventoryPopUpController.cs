using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPopUpController : MonoBehaviour
{
    public CanvasGroup inventoryPopup;
    public CanvasGroup buttonPanel;
    public void OpenInventoryPopUp()
    {
        inventoryPopup.alpha = 1.0f;
        inventoryPopup.blocksRaycasts = true;

        buttonPanel.alpha = 0f;
        buttonPanel.blocksRaycasts = false;
    }

    public void CloseInventoryPopUp()
    {
        inventoryPopup.alpha = 0f;
        inventoryPopup.blocksRaycasts = false;

        buttonPanel.alpha = 1.0f;
        buttonPanel.blocksRaycasts = true;
    }
}
