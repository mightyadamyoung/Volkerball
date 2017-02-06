using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSwitch : MonoBehaviour
{
    public Button menuB;
    void Start()
    {

        Button men = menuB.GetComponent<Button>();
        men.onClick.AddListener(TaskOnClick1);
    }
    public void TaskOnClick1()
    {
        SceneManager.LoadSceneAsync("TitleScene", LoadSceneMode.Single);
    }
}
