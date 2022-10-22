using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    // Positions to store random values.
    private float xPosition, yPosition, zPosition;

    // Ranges
    private float xRange = 5f;
    private float yRange = 4f;
    private float zRange = 5f;

    void Update()
    {
        // If the Enter key is pressed.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Generates random values within the specified ranges.
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            // Moves the object to a random position.
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
