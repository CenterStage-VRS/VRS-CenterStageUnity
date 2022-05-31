using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWithinZoneSpawner : ObjectSpawner
{
    public int numberToSpawn;
    public GameObject spawnParent;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider boxCollider = GetComponent<BoxCollider>();

        while(numberToSpawn > 1)
        {
            float newX = Random.Range(boxCollider.bounds.min.x, boxCollider.bounds.max.x);
            float newY = Random.Range(boxCollider.bounds.min.y, boxCollider.bounds.max.y);
            float newZ = Random.Range(boxCollider.bounds.min.z, boxCollider.bounds.max.z);

            GameObject newObject = Instantiate(objectPrefab, spawnParent.transform);
            newObject.transform.position = new Vector3(newX, newY, newZ);

            numberToSpawn--;
        }

        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
