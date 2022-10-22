using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereMat;

    private void Start()
    {
        // Gets the material from the renderer component.
        sphereMat = sphere.GetComponent<Renderer>().material;
    }

    // Changes the transparency of the sphere according to the slider value.
    public void ChangeSphereAlpha(float value)
    {
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, value);
    }
}
