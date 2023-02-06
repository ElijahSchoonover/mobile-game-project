using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale != 0)
            {
                //pause game
                PauseGame();
            }
            else
            {
                //unpause game
                Resume();
            }
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    public void Resume()
    {
        //Resume The Game
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}