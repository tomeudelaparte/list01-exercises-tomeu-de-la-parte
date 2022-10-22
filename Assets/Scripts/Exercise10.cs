using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private int score = 0;

    private void Start()
    {
        counter.text = score.ToString();
    }

    public void AddPoint()
    {
        score++;

        counter.text = score.ToString();
    }
}
