using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip GameStartSound;
    public AudioClip GameLoseSound;
    public AudioClip GameWinSound;
    public AudioClip OpenDoorSound;
    public AudioClip ClueBookSound;
    public AudioClip BackgroundMusic;

    public static Sounds Instance;

    private AudioSource audioSource;

    public void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayStart()
    {
        audioSource.PlayOneShot(GameStartSound);
    }

    public void PlayLose()
    {
        audioSource.PlayOneShot(GameLoseSound);
    }

    public void PlayWon()
    {
        audioSource.PlayOneShot(GameWinSound);
    }

    public void PlayDoorSound()
    {
        audioSource.PlayOneShot(OpenDoorSound);
    }

    public void PlayBookSound()
    {
        audioSource.PlayOneShot(ClueBookSound);
    }

    public void PlayBackgroundMusic()
    {
        audioSource.PlayOneShot(BackgroundMusic);
    }
}
