// Objective: Input accelerations & break forces to the robot with keyboard inputs.
// Dependencies: <wheel_mechanics.cs>
// Author: Damith Tennakoon

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard_controller : MonoBehaviour
{
    // Create a local instance of the wheel_mechanics class
    [SerializeField] private wheel_mechanics wheelMechanics;

    // Define local variables to store acceleration, break, and turn inputs
    [SerializeField] private float inputAccel = 500f; // UNITS {m/s}
    [SerializeField] private float inputBreakForce = 300f; // UNITS {N}
    [SerializeField] private float inputTurnAngle = 35f; // UNITS {DEG}

    void Start()
    {
        // Log initialization 
        Debug.Log("Initializing Keyboard Controller script...");
    }

    void Update()
    {
        // Apply forward/backward accelerations using W and S keys
        if (Input.GetKey(KeyCode.W))
        {
            wheelMechanics.currentAccel = inputAccel * (1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            wheelMechanics.currentAccel = inputAccel * (-1);
        }
        else
        {
            wheelMechanics.currentAccel = 0.0f;
        }

        // Apply break force using the SPACE key
        if (Input.GetKey(KeyCode.Space))
        {
            wheelMechanics.currentBreakForce = inputBreakForce;
        }
        else
        {
            wheelMechanics.currentBreakForce = 0.0f;
        }

        // Apply turn angle using the D and A keys
        if (Input.GetKey(KeyCode.D))
        {
            wheelMechanics.currentTurnAngle = inputTurnAngle * (1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            wheelMechanics.currentTurnAngle = inputTurnAngle * (-1);
        }
        else
        {
            wheelMechanics.currentTurnAngle = 0.0f;
        }

    }
}
