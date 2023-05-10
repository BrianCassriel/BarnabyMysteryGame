using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{
    public GameObject barnaby;
    public new Camera camera;
    public int doorwayNumber;

    private readonly List<Vector3> _doorwayLocations = new List<Vector3>
    {
        new Vector3(40, 0, 0),
        new Vector3(40, -20, 0),
        new Vector3(40, -30, 0),
        new Vector3(80, 0, 0)
    };

    private Vector3 GetDoorwayLocation()
    {
        return _doorwayLocations[doorwayNumber];
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            MoveFromDoorway();
        }
    }

    private void MoveFromDoorway()
    {
        barnaby.transform.position = GetDoorwayLocation();
        camera.transform.position = new Vector3(barnaby.transform.position.x, barnaby.transform.position.y, -10);
    }
}
