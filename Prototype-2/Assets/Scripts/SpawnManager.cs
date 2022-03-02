using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variables
    public GameObject[] animalPrefabs;

    void Start()
    {
        
    }

    void Update()
    {
        // variables
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // player input for spawning animal prefabs
        if (Input.GetKeyDown(KeyCode.S)) {
            // spawns a random animal prefab from given array of animal prefabs along with its preset rotation
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-20, 20), 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
