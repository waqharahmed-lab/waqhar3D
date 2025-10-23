using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour

{
    public float speed = 15f;
    public float rotationSpeed = 50f;
    private float verticalInput;

    void Update()
    {
        // Get input from the up/down arrow keys (or W/S)
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a consistent speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt the plane based on vertical input only
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}


