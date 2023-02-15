using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public string restartSceneName;
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
        isPaused = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }
        if (isPaused == true)
        {
            PauseGame();
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
        isPaused = false;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(restartSceneName);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}