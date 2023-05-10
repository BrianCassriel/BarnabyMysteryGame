using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Barnaby barnaby;
    private int _cluesFound = 0;
    private readonly Dictionary<string, Vector4> uiScreenMapLocations = new Dictionary<string, Vector4>
    {
        {"Lose", new Vector4(-40, 0, 0, 9)},
        {"Win", new Vector4(-40, -20, 0, 9)},
    };

    public void IncrementCluesFound()
    {
        _cluesFound++;
    }
    
    public void ShowWinUI()
    {
        barnaby.Warp(uiScreenMapLocations["Win"]);
    }
    
    public void ShowLoseUI()
    {
        barnaby.Warp(uiScreenMapLocations["Lose"]);
    }
}
