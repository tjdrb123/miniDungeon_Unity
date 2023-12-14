using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UIManager : MonoBehaviour
{
    [SerializeField] private ItemSlot[] itemSlots;
    [SerializeField] TMP_Text goldTxt;
    [SerializeField] TMP_Text IdTxt;
    [SerializeField] TMP_Text levelTxt;
    [SerializeField] TMP_Text attackTxt;
    [SerializeField] TMP_Text defenseTxt;
    [SerializeField] TMP_Text healthTxt;
    [SerializeField] TMP_Text criticalTxt;

    private void Update() // Start로 바꾸고 값이 계속 바뀌게끔 수정필요
    {
        goldTxt.text = GameManager.Instance.userData.gold.ToString();
        IdTxt.text = GameManager.Instance.userData.Id;
        levelTxt.text = "Lv " + GameManager.Instance.userData.level.ToString();
        attackTxt.text = GameManager.Instance.userData.critical.ToString() + " +(" + SumStats(DataManager.instance.gameData.myItems, ItemType.weapon) + ")";
        defenseTxt.text = GameManager.Instance.userData.defense.ToString() + " +(" + SumStats(DataManager.instance.gameData.myItems, ItemType.armor) + ")";
        healthTxt.text = GameManager.Instance.userData.health.ToString();
        criticalTxt.text = GameManager.Instance.userData.critical.ToString();
    }

    public void SetInventory()
    {
        for (int i = 0;  i < DataManager.instance.gameData.myItems.Length; i++)
        {
            itemSlots[i].Init(DataManager.instance.gameData.myItems[i]);
        }
    }
    private int SumStats(ItemData[] myitems, ItemType type)
    {
        int sum = 0;
        for (int i = 0; i < myitems.Length; i++)
        {
            if (myitems[i].type == type && myitems[i].isEquiped)
            {
                sum += myitems[i].itemStat;
            }
        }
        return sum;
    }
}


