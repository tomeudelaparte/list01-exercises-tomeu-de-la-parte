using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public GameObject cylinder;

    private Material cylinderMat;

    private void Start()
    {
        cylinderMat = cylinder.GetComponent<Renderer>().material;
    }

    public void ChangeCylinderColor(int index)
    {
        switch (index)
        {
            case 0:
                cylinderMat.color = Color.white;
                break;

            case 1:
                cylinderMat.color = Color.red;
                break;

            case 2:
                cylinderMat.color = Color.green;
                break;

            case 3:
                cylinderMat.color = Color.blue;
                break;

            case 4:
                cylinderMat.color = Color.yellow;
                break;

            default:
                cylinderMat.color = Color.white;
                break;
        }
    }
}
