using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Vector3[] positions;

    private int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (index < positions.Length)
            {
                Instantiate(capsulePrefab, positions[index], capsulePrefab.transform.rotation);

                index++;
            }
        }
    }
}
