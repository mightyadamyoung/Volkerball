using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour {

	
    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadSceneAsync("GameOver", LoadSceneMode.Single);
    }
}
