using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereMat;

    private void Start()
    {
        sphereMat = sphere.GetComponent<Renderer>().material;
    }

    public void ChangeSphereAlpha(float value)
    {
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, value);
    }
}
