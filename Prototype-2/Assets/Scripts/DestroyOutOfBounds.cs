using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // variables
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // destroys gameobject if its transform position on the z-axis exceeds more than its top or lower boundary
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }else if (transform.position.z < lowerBound) {
            Destroy(gameObject);
        }
    }
}
