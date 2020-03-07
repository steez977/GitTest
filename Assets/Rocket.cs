using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            print("space pressed!");
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Turn left!");
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Turn right!");
        }

    }
}
