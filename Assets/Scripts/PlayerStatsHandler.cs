using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatsHandler : MonoBehaviour
{
    [SerializeField] PlayerStatsSO playerStats;

    [SerializeField] private TextMeshProUGUI attackTxt;
    [SerializeField] private TextMeshProUGUI defenseTxt;
    [SerializeField] private TextMeshProUGUI healthTxt;
    [SerializeField] private TextMeshProUGUI criticalTxt;

    private void Start()
    {
        UpdatePlayerStats();
    }

    private void UpdatePlayerStats()
    {
        attackTxt.text = playerStats.attackPower.ToString();
        defenseTxt.text = playerStats.defensePower.ToString();
        healthTxt.text = playerStats.health.ToString();
        criticalTxt.text = playerStats.criticalHit.ToString();

    }
}
