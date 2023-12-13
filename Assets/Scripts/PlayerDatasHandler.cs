using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDatasHandler : MonoBehaviour
{
    [SerializeField] private PlayerDatasSO playerDatas;

    [SerializeField] private TextMeshProUGUI idTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;
    
    private void Start()
    {
        UpdatePlayerDatas();
    }

    private void UpdatePlayerDatas()
    {
        idTxt.text = playerDatas.playerId;
        levelTxt.text = "Lv " + playerDatas.level.ToString();
        goldTxt.text = playerDatas.gold.ToString();
    }
}
