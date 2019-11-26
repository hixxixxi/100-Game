using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelMenu : MonoBehaviour
{
    public GameObject nextLevelUI;

    public void NextLevel (){

        // turn off menu 
        nextLevelUI.SetActive(false);
        Time.timeScale = 1f;

        TargetGenerator.IncreaseDifficulty();

    }
}
