using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public string restartName;
    public string nextLevelName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(restartName);
    }
    public void Resume()
    {
        SceneManager.LoadScene(nextLevelName);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
