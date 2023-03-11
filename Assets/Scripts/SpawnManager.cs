using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnEveryXSeconds;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] spawnableObjects;

    private float _nexSpawnTime = 0f;


    private void FixedUpdate()
    {
        SpawnTimeControl();
    }

    private void SpawnTimeControl()
    {
        if (Time.time > _nexSpawnTime)
        {
            _nexSpawnTime += spawnEveryXSeconds;
            ObjectSpawner(spawnableObjects[SpawnPicker()], spawnPositions[RandomSpawnNumber()]);
        }
    }
    //Instantiate(coinPrefab, transform.position, transform.rotation);

    private void ObjectSpawner(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation);
    }

    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);
    }

    private int SpawnPicker()
    {
        return Random.Range(0, spawnableObjects.Length);
    }
}