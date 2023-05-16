using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Barnaby barnaby;
    private int _cluesFound = 0;

    private void Start()
    {
        Sounds.Instance.PlayStart();
    }

    public void IncrementCluesFound()
    {
        _cluesFound++;
    }
    
    public void GotoWinIsland()
    {
        barnaby.Warp(new Vector4(-40, -20, 0, 9));
        barnaby.transform.localScale = new Vector3(1f, 1f, 1f);
        Sounds.Instance.PlayWon();
    }
    
    public void GotoLoseIsland()
    {
        barnaby.Warp(new Vector4(-40, 0, 0, 9));
        barnaby.transform.localScale = new Vector3(1f, 1f, 1f);
        Sounds.Instance.PlayLose();
    }
}
