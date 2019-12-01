using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonScript : MonoBehaviour
{
    //always starts at easy, 1 = easy
    public Text DifficultyText;
    public static string difficulty = "Difficulty: Easy";
    public static int difficultyBaselineNum = 1;

    public void easy() {
        difficulty = "Difficulty: Easy";
        difficultyBaselineNum = 1;
        TargetGenerator.limit = difficultyBaselineNum;
    }

    public void medium()
    {
        difficulty = "Difficulty: Medium";
        difficultyBaselineNum = 2;
        TargetGenerator.limit = difficultyBaselineNum;
    }

    public void hard()
    {
        difficulty = "Difficulty: Hard";
        difficultyBaselineNum = 3;
        TargetGenerator.limit = difficultyBaselineNum;
    }

}
