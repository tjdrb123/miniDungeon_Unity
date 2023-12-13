using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Datas", order = 1)]
public class PlayerDatasSO : ScriptableObject
{
    [Header("PlayerDatas")]
    public string playerId;
    public int level;
    public int gold;
}
