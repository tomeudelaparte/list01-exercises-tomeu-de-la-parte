using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int minNumber, maxNumber;

    public void GenerateRandomNumber()
    {
        textTMP.text = Random.Range(minNumber, maxNumber).ToString();
    }
}
