using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(ObjectSpawnLocationTracker))]
public class ObjectSpawnManager : MonoBehaviour
{

    public SpawnableObjectData[] spawnableObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class SpawnableObjectData
{
    public string objectName;
    public SpawnableObject spawnableObject;
    public Transform[] objectPositions; // The parent transform for a set of locations on the field that
    // should be filled by a set of the spawnableObject prefabs.
}



