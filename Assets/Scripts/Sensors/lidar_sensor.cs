// Objective: Utilize the Ray method to simulate a LiDAR sensor
// Dependencies: <>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lidar_sensor : MonoBehaviour
{
    // Define parameter to store maximum LiDAR length
    [SerializeField] private float lidarDistance = 10f; // UNIT {M}

    [SerializeField] private float rotationSpeed = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the sensor
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Get the direction to transmit the ray from the current sensor object
        Vector3 rayDirection = transform.forward;

        // Transmit a ray and store teh return signals into a RaycastHit list
        RaycastHit[] hits = Physics.RaycastAll(transform.position, rayDirection, lidarDistance);

        // Define parameter to store return distance
        float distance;

        //  Check if rays hit
        if (hits.Length > 0)
        {
            // Store the distance 
            distance = hits[0].distance;

            // Draw the casted signal 
            Debug.DrawRay(transform.position, rayDirection * distance, Color.red);

        }
        // If there are no hits
        else
        {
            // Set null distance
            distance = 100f;

            // Draw the casted signal
            Debug.DrawRay(transform.position, rayDirection * lidarDistance, Color.blue);
        }

        // Log the distance
        Debug.Log("LIDAR OUTPUT: " + distance + " meters");

    }
}
