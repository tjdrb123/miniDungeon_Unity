using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player/Stats", order = 0)]
public class PlayerStatsSO : ScriptableObject
{
    [Header("PlayerStats")]
    public int attackPower;
    public int defensePower;
    public int health;
    public int criticalHit;
}