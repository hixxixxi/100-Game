﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject NextLevelUI;
    public GameObject DeathUI;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }

    public void NextLevel()
    {
        NextLevelUI.SetActive(true);
        Time.timeScale = 0f;

    }
    public void DeathMenu() {
        DeathUI.SetActive(true);
        PauseMenu.GameIsPaused = true;
        Time.timeScale = 0f;
        
    }
}
