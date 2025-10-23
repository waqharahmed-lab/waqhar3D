using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

{
    public float speed = 15.0f;        // Forward/backward movement speed
    public float turnSpeed = 50.0f;    // Turning speed
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // Get user input
        horizontalInput = Input.GetAxis("Horizontal");  // A/D or Left/Right arrows
        verticalInput = Input.GetAxis("Vertical");      // W/S or Up/Down arrows

        // Move the car forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Turn the car left and right
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
