using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

{
    public float speed = 15.0f;         // Slower speed for manageable control
    public float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // Get user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Tilt the plane up/down when pressing Up/Down arrows
        transform.Rotate(Vector3.right * verticalInput * turnSpeed * Time.deltaTime);

        // Turn the plane left/right
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }
}
