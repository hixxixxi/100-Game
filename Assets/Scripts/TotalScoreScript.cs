using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreScript : MonoBehaviour
{
    public static int totalScoreValue = 0;
    public Text totalScore;
    // Start is called before the first frame update
    void Start()
    {
        totalScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalScore.text = "Total Score: " + totalScoreValue;
    }
}
