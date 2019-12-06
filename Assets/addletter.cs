using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addletter : MonoBehaviour
{
    public GameObject textinput;
    public Text addChar;

    // Start is called before the first frame update
    public void AddC()
    {
        string charr = addChar.text;
        Text input = textinput.GetComponent<Text>();

        if (input.text.Length == 26)
        {
            input.text = charr;
        }
        else {
            input.text += charr;
        }
    }

    public void DeleteLast() {
        Text input = textinput.GetComponent<Text>();
        if (input.text.Length == 26)
        {
            input.text = "";
        }

        string deleted = input.text.Remove(input.text.Length -1);
        input.text = deleted;
    }
}
