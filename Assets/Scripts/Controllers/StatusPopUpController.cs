using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPopUpController : MonoBehaviour
{
    public CanvasGroup statusPopUp;
    public CanvasGroup buttonPanel;
    public void OpenStatusPopUp()
    {
        statusPopUp.alpha = 1.0f;
        statusPopUp.blocksRaycasts = true;

        buttonPanel.alpha = 0f;
        buttonPanel.blocksRaycasts = false;
    }

    public void CloseStatusPopUp()
    {
        statusPopUp.alpha = 0f;
        statusPopUp.blocksRaycasts = false;

        buttonPanel.alpha = 1.0f;
        buttonPanel.blocksRaycasts = true;
    }
}
