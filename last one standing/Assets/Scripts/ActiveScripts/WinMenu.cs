using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public string restartName;
    //public string nextLevelEasy;
    //public string nextLevelNormal;
    //public string nextLevelHard;
    public int lastLevelNumber;
    public int nextLevelNumber;
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
        //SceneManager.LoadScene(restartName);
        if (Dificulty.isEasy && lastLevelNumber <= 3)
        {
            SceneManager.LoadScene($"easy {lastLevelNumber}");
        }
        else if (Dificulty.isNormal)
        {
            
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene($"Hard {lastLevelNumber}");
        }
    }
    public void NextLevel()
    {
        //SceneManager.LoadScene(nextLevelName);
        if (Dificulty.isEasy && nextLevelNumber < 4)
        {
            SceneManager.LoadScene($"easy {nextLevelNumber}");
        }
        else if (Dificulty.isEasy && nextLevelNumber > 3)
        {
            SceneManager.LoadScene("EasyFinish");
        }
        else if (Dificulty.isNormal)
        {

        }
        else if (Dificulty.isHard && nextLevelNumber < 7 )
        {
            SceneManager.LoadScene($"Hard {nextLevelNumber}");
        }
        else if (Dificulty.isHard && nextLevelNumber > 6)
        {
            SceneManager.LoadScene("HardFinish");
        }
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
