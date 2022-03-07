using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variables
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // player input for spawning animal prefabs from animal spawning function
        if (Input.GetKeyDown(KeyCode.S)) {
            // calls animal spawning function
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal() {
        // variables
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // spawns a random animal prefab from given array of animal prefabs along with its preset rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
