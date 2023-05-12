using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    public Game game;
    public int clueNumber;

    public int GetClueNumber()
    {
        return clueNumber;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            game.IncrementCluesFound();
            Destroy(gameObject);
        }
    }
}
