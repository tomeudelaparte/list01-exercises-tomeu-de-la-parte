using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (number % 2 == 0)
            {
                textTMP.text = "The number " + number + " is EVEN";
            }
            else
            {
                textTMP.text = "The number " + number + " is ODD";
            }
        }
    }
}
