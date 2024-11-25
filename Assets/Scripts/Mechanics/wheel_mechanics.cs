// Objective: Defines the wheel mechanics & properties of the rover + applies accelerations to wheels.
// Dependencies: <>,
// Author: Damith Tennakoon

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_mechanics : MonoBehaviour
{
    // Define accessible Wheele Collider objects
    public WheelCollider frontRightWheel;
    public WheelCollider frontLeftWheel;
    public WheelCollider backLeftWheel;
    public WheelCollider backRightWheel;

    // Define private Trasnform objects for each wheel mesh
    [SerializeField] private Transform frontRightTransform;
    [SerializeField] private Transform frontLefttTransform;
    [SerializeField] private Transform backRightTransform;
    [SerializeField] private Transform backLeftTransform;

    // Define accessible robot state parameters 
    public float currentAccel = 0.0f;
    public float currentBreakForce = 0.0f;
    public float currentTurnAngle = 0.0f;

    void Start()
    {
        // Debug Initialization of script
        Debug.Log("Initializing Wheel Mechanics script...");
    }

    // Update is called once per frame
    void Update()
    {
        // Continously apply accelerations to wheels -> RWD
        backRightWheel.motorTorque = currentAccel;
        backLeftWheel.motorTorque = currentAccel;

        /* TEST
        frontRightWheel.motorTorque = currentAccel;
        frontLeftWheel.motorTorque = -1*currentAccel;
        backRightWheel.motorTorque = currentAccel;
        backLeftWheel.motorTorque = -1*currentAccel;
         TEST */

        // Continously apply breaking force to all wheels 
        frontRightWheel.brakeTorque = currentBreakForce;
        frontLeftWheel.brakeTorque = currentBreakForce;
        backRightWheel.brakeTorque = currentBreakForce;
        backLeftWheel.brakeTorque = currentBreakForce;

        // Continously apply turn angles to front two wheels
        frontRightWheel.steerAngle = currentTurnAngle;
        frontLeftWheel.steerAngle = currentTurnAngle;

        // Update wheel meshes
        UpdateWheel(frontLeftWheel, frontLefttTransform);
        UpdateWheel(frontRightWheel, frontRightTransform);
        UpdateWheel(backLeftWheel, backLeftTransform);
        UpdateWheel(backRightWheel, backRightTransform);
    }

    // Rotate the wheel meshes
    void UpdateWheel(WheelCollider col, Transform trans)
    {
        // Access the wheele collider states
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        // Set the pose to the transform object
        trans.position = position;
        trans.rotation = rotation;
    
    }


}
