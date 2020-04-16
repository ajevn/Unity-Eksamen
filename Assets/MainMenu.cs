using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Canvas menu;

    bool menuIsOpen;

    public void PlayGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void QuitMenu() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuIsOpen = !menuIsOpen;

            if (menuIsOpen)
            {
                menu.enabled = true;
                Time.timeScale = 0;
            }
            if (!menuIsOpen)
            {
                menu.enabled = false;
                Time.timeScale = 1;
            }
        }
    }
    
}