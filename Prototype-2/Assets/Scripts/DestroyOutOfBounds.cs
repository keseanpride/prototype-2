using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // variables
    private float topBound = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // destroys gameobject if its transform position on the z-axis exceeds more than its top boundary
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
    }
}
