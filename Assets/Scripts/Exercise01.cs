using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    private int minNumber = 0;
    private int maxNumber = 100;

    // Generates a random number from a range.
    public void GenerateRandomNumber()
    {
        // Displays the value on the screen.
        textTMP.text = Random.Range(minNumber, maxNumber).ToString();
    }
}
