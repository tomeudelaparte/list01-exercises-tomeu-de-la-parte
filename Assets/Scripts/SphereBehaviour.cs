using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    private Exercise10 manager;

    private void Start()
    {
        manager = FindObjectOfType<Exercise10>();
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            manager.AddPoint();

            Destroy(gameObject);
        }
    }
}