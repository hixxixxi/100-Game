using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 1;
    public Text score;
    //finalScoreValue is what gets score after level is completed., probably do not need
    public static int finalScoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + scoreValue;
    }
}
