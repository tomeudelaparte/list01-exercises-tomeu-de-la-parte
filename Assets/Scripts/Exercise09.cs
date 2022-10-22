using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise09 : MonoBehaviour
{
    public Toggle lightSwitch;
    public GameObject pointLight;

    private void Start()
    {
        SwitchLight(lightSwitch.isOn);
    }

    public void SwitchLight(bool isOn)
    {
        if (isOn)
        {
            pointLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            pointLight.GetComponent<Light>().enabled = false;
        }
    }
}
