﻿
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {


    public void PlayGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
	}

    public void QuitMenu() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }
    
}