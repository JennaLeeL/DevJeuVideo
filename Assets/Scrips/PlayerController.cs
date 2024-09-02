using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{    
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwardInput;
    
    // Set Keys on Unity Up and Down Arrow
    public KeyCode startKey = KeyCode.UpArrow; 
    public KeyCode stopKey = KeyCode.DownArrow; 

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        

    // Moves the car foward based on vertical input
    
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       // transform.position = transform.position + (transform.forward * speed * Time.deltaTime);

    // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
