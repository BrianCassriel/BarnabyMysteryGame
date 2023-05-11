using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip GameStartSound;
    public AudioClip GameLoseSound;
    public AudioClip OpenDoorSound;
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayStart()
    {
        audioSource.PlayOneShot(GameStartSound);
    }

    public void PlayLose()
    {
        audioSource.PlayOneShot(GameLoseSound);
    }

    public void PlayDoorSound()
    {
        audioSource.PlayOneShot(OpenDoor);
    }
}
