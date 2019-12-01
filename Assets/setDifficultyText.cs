using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setDifficultyText : MonoBehaviour
{
    // Start is called before the first frame update
    Text DifficultyText;
    void Start()
    {
        DifficultyText = GetComponent<Text>();
        DifficultyText.text = DifficultyButtonScript.difficulty;

    }
}
