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
        // Pressing the spacebar, verifies whether the inserted number is odd or even.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If the remainder is 0, dividing the inserted number and the divisor.
            if (number % 2 == 0)
            {
                // Displays a message on the screen.
                textTMP.text = "The number " + number + " is EVEN";
            }
            else
            {
                // Displays a message on the screen.
                textTMP.text = "The number " + number + " is ODD";
            }
        }
    }
}
