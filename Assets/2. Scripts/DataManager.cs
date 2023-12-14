using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public UserData userData;
    public GameData gameData;
    private void Awake()
    {
        instance = this;
    }
}
