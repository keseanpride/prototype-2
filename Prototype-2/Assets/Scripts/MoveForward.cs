using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // variables
    public float foodSpeed = 50.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // food's forward movement along the z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);
    }
}
