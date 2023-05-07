using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Water")
            print("Water");
        
        if(collision.gameObject.name == "Building")
            print("Building");
        
        if(collision.gameObject.name == "Tree")
            print("Tree");
    }
    
}
