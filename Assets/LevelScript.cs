using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    public static int levelValue = 0;
    public Text LevelText;
    // Start is called before the first frame update
    void Start()
    {
        LevelText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LevelText.text = "Level: " + levelValue;
    }
}
