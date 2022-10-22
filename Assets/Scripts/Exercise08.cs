using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Exercise08 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;

    private string regexPattern = "^[A-Za-z0-9_.]+$";

    public void ConfirmUsername()
    {
        if (Regex.IsMatch(username.text, regexPattern))
        {
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}