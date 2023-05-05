using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{
    public GameObject barnaby;
    public int doorwayNumber;
    
    private readonly List<Vector3> _doorwayLocations = new List<Vector3>
    {
        new Vector3(40, 0, 0),
        new Vector3(40, -20, 0),
        new Vector3(40, -30, 0),
        new Vector3(80, 0, 0)
    };

    public Vector3 GetDoorwayLocation()
    {
        return _doorwayLocations[doorwayNumber];
    }
}
