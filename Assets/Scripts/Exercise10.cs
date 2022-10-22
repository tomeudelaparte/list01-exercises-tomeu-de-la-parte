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
        // Reset counter to zero.
        counter.text = score.ToString();
    }

    // Adds +1 to the score and updates the text.
    public void AddPoint()
    {
        score++;

        counter.text = score.ToString();
    }
}
