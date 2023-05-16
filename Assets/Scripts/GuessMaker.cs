using System;
using System.Collections;
using UnityEngine;

public class GuessMaker : MonoBehaviour
{
    public Game game;
    private CanvasGroup _guessGUI;
    private bool _isHidden = true;
    private bool _hasGuessed = false;
    
    private void Awake()
    {
        _guessGUI = this.GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        CanvasGroupDisplayer.Hide(_guessGUI);
    }

    public void ToggleGuessGUI()
    {
        if (_isHidden)
        {
            CanvasGroupDisplayer.Show(_guessGUI);
            _isHidden = false;
        }
        else
        {
            CanvasGroupDisplayer.Hide(_guessGUI);
            _isHidden = true;
        }
    }

    public void GuessMurderer(String guess)
    {
        if (_hasGuessed) return;
        print("guess: " + guess);
        game.GotoFinalIsland(guess.Equals("Sandie") ? "Win" : "Lose");
        _hasGuessed = true;
    }
}
