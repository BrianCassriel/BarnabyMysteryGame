using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluePopUp : MonoBehaviour
{
    public GameObject popupPanel;

    private bool spriteCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!spriteCollected && other.CompareTag("Sprite"))
        {
            CollectSprite();
        }
    }

    private void CollectSprite()
    {
        spriteCollected = true;
        popupPanel.SetActive(true);
    }

}
