using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;

    float z;
    float x;
    float y;

    [SerializeField] float rotationSpeed = 50.0f;
    [SerializeField] float thrustSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // print("Update");
        ProcessInput();
    }

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            // print("Thrusting!");
            rigidBody.AddRelativeForce(Vector3.up * thrustSpeed);
        }

        rigidBody.freezeRotation = true; 

        if (Input.GetKey(KeyCode.A))
        {
            // print("Turn left!");
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
        else 
        {
            if((Input.GetKey(KeyCode.D)))
            {
                // print("Turn right!");
                transform.Rotate(-Vector3.forward * Time.deltaTime * rotationSpeed);
            }

        }
        rigidBody.freezeRotation = false;
    }
}
