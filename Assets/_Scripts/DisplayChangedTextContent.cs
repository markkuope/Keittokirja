using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DisplayChangedTextContent : MonoBehaviour
{
    public TMP_InputField inputField;
    TMP_Text textDisplay;

    void Awake()
    {
        textDisplay = GetComponent<TMP_Text>();
    }

    public void DisplayNewValue()
    {
        textDisplay.text = "Nimesi on = '" + inputField.text +"'";
    }

}
