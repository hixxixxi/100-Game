using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame()
    {
        //Reset all things from last game, really buggy code
        TargetGenerator.limit = DifficultyButtonScript.difficultyBaselineNum;
        TotalScoreScript.totalScoreValue = 0;
        ScoreScript.scoreValue = 0;
        LevelScript.levelValue = 1;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void GoBackToMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

