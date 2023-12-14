using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UserData_", menuName = "Data/UserData", order = 0)]
public class UserData : ScriptableObject
{
    [Header("Info")]
    public string Id;
    public int level;
    public int gold;

    [Header("Stats")]
    public int attack;
    public int defense;
    public int health;
    public int critical;
}