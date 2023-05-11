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
    
    public void ShowWinUI()
    {
        print("You win!");
        throw new NotImplementedException();
        Sounds.Instance.PlayWon();
    }
    
    public void ShowLoseUI()
    {
        print("You lose!");
        throw new NotImplementedException();
        Sounds.Instance.PlayLose();
    }
}
