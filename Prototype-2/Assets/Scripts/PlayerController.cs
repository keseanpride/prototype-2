using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float horizontalInput;
    public float horizontalSpeed = 10.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        // player's horizontal input is set from Unity's input manager
        horizontalInput = Input.GetAxis("Horizontal");
        // player's horizontal movement
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalSpeed);

        // boundary movement set for player along x-axis
        if (transform.position.x < -10) {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
    }
}
