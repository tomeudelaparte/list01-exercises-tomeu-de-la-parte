using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    private Exercise10 manager;

    private void Start()
    {
        // Gets the main script as manager
        manager = FindObjectOfType<Exercise10>();
    }

    // If the mouse is over the GameObject 
    private void OnMouseOver()
    {
        // Clicks on it
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Add point to score
            manager.AddPoint();

            // Destroy the GameObject
            Destroy(gameObject);
        }
    }
}