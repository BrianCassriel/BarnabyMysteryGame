using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class Doorway : MonoBehaviour
{
    public Barnaby barnaby;
    public string mapLocationKey;

    private readonly Dictionary<string, Vector4> _mapLocations = new Dictionary<string, Vector4>
    {
        { "Town", new Vector4(0, 0, 0, 12) },
        { "HouseOne", new Vector4(40, 0, 0, 6) },
        { "HouseTwo", new Vector4(40, -20, 0, 6) },
        { "HouseThree", new Vector4(40, -40, 0, 6) },
        { "HouseFour", new Vector4(80, 0, 0, 4) },
    };

    private Vector4 GetMapLocation()
    {
        return _mapLocations[mapLocationKey];
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
        barnaby.Warp(GetMapLocation());
        Sounds.Instance.PlayDoorSound();
    }

    public void AutoSetBarnabyScale(Vector4 location)
    {
        if (location.Equals(_mapLocations["Town"]))
            barnaby.transform.localScale = new Vector3(1f, 1f, 1f);
        else if (location.Equals(_mapLocations["HouseOne"])
                 || location.Equals(_mapLocations["HouseTwo"])
                 || location.Equals(_mapLocations["HouseThree"]))
            barnaby.transform.localScale = new Vector3(2/3f, 2/3f, 1f);
        else if (location.Equals(_mapLocations["HouseFour"]))
            barnaby.transform.localScale = new Vector3(1/3f, 1/3f, 1f);
        else
            barnaby.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
