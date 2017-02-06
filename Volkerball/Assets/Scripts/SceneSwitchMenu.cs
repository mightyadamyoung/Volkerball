﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitchMenu : MonoBehaviour
{
    public Button playB;
    public Button menuB;
    public Button exitB;

    void Start()
    {
        Button ply = playB.GetComponent<Button>();
        ply.onClick.AddListener(TaskOnClick);

        Button men = menuB.GetComponent<Button>();
        men.onClick.AddListener(TaskOnClick1);

        Button ext = exitB.GetComponent<Button>();
        ext.onClick.AddListener(TaskOnClick2);

        
    }
    public void TaskOnClick()
    {
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }
    public void TaskOnClick1()
    {
        SceneManager.LoadSceneAsync("TitleScene", LoadSceneMode.Single);
    }
    public void TaskOnClick2()
    {
        Application.Quit();
    }
}


