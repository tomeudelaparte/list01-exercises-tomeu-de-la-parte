using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Exercise08 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;

    // Regular expression that avoids blank spaces. Only accepts letters, numbers and signs.
    private string regexPattern = "^[A-Za-z0-9_.]+$";

    public void ConfirmUsername()
    {
        // Checks if the username is compatible with the regular expression.
        if (Regex.IsMatch(username.text, regexPattern))
        {
            // Displays a message on the screen.
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}