using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    private float xPosition, yPosition, zPosition;

    private float xRange = 5f;
    private float yRange = 4f;
    private float zRange = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
