using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // private variables
    public float speed = 5.0f;
    public float rotationSpeed = 25f;
    public float verticalInput;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);

        
        
    }
}
