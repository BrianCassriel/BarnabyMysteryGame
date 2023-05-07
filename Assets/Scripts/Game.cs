using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    
    private int _cluesFound = 0;

    public void IncrementCluesFound()
    {
        _cluesFound++;
    }
    
    public void DecreaseCluesFound(int amount)
    {
        _cluesFound -= amount;
    }

    public void ShowWinUI()
    {
        throw new NotImplementedException();
    }

    public void ShowLoseUI()
    {
        throw new NotImplementedException();
    }
}
