using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Props/Scoring Object")]
public class ScoringObject: ScriptableObject
{
    public GameObject objectPrefab;
    [Range(0,100)]
    public int quantityToSpawn;
    public SpawnType spawnType;

    public List<Vector3> pointPositions { get; set; }

    public SpawnAreaBounds spawnAreaBounds { get; set; }


}

[System.Serializable]
public class SpawnAreaBounds
{
    public Vector3 lowerBound, upperBound;
}

public enum SpawnType
{
    StackedAtPoint,
    AtSpecificPoints,
    RandomOverArea,
    RandomOverMultiplePoints
}
