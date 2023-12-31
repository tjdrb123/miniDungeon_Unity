using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData", order = 2)]
public class GameData : ScriptableObject
{
    // 내가 보유 중인 아이템 정보
    public ItemData[] myItems;
}
