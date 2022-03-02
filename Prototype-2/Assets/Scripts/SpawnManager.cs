using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // variables
    public GameObject[] animalPrefabs;
    public int animalIndex;

    void Start()
    {
        
    }

    void Update()
    {
        // player input for spawning animal prefabs
        if (Input.GetKeyDown(KeyCode.S)) {
            // spawns animal prefab from given array of animal prefabs along with its preset rotation
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
