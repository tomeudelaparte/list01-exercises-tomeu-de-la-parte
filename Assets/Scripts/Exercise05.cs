using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public GameObject capsulePrefab;
    public Vector3[] positions;

    void Update()
    {
        // If the S key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Search and store all capsules with an especified tag in an array.
            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsule");

            // Each existing capsule is deleted.
            foreach (GameObject obj in capsulesInGame)
            {
                Destroy(obj);
            }

            // Instantiate a capsule at each position of the array.
            foreach (Vector3 pos in positions)
            {
                Instantiate(capsulePrefab, pos, capsulePrefab.transform.rotation);
            }
        }
    }
}
