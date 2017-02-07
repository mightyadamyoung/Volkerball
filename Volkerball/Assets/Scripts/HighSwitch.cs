using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighSwitch : MonoBehaviour
{

    public Button playB;
    public Button highB;
    public Button exitB;
    void Start ()
    {
        Button ply = playB.GetComponent<Button>();
        ply.onClick.AddListener(TaskOnClick);

        Button hig = highB.GetComponent<Button>();
        hig.onClick.AddListener(TaskOnClick3);

        Button ext = exitB.GetComponent<Button>();
        ext.onClick.AddListener(TaskOnClick2);
    }
    public void TaskOnClick()
    {
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }
    public void TaskOnClick2()
    {
        Application.Quit();
    }
    public void TaskOnClick3()
    {
        SceneManager.LoadSceneAsync("HighScore", LoadSceneMode.Single);
    }
}
