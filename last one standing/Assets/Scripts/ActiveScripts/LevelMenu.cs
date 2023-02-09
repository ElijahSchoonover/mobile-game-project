using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public string level1Easy;
    public string level1Normal;
    public string level1Hard;
    public string level2Easy;
    public string level2Normal;
    public string level2Hard;
    public string level3Easy;
    public string level3Normal;
    public string level3Hard;
    public string level4Normal;
    public string level4Hard;
    public string level5Hard;
    public string level6Hard;
    public string mainMenu;
    public string howToPlay;
    public string credits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void LoadLevelOne()
    {
        if (Dificulty.isEasy)
        {
            SceneManager.LoadScene(level1Easy);
        }
        else if (Dificulty.isNormal)
        {
            SceneManager.LoadScene(level1Normal);
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level1Hard);
        }
    }
    public void LoadLevelTwo()
    {
        if (Dificulty.isEasy)
        {
            SceneManager.LoadScene(level2Easy);
        }
        else if (Dificulty.isNormal)
        {
            SceneManager.LoadScene(level2Normal);
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level2Hard);
        }
    }
    public void LoadLevelThree()
    {
        if (Dificulty.isEasy)
        {
            SceneManager.LoadScene(level3Easy);
        }
        else if (Dificulty.isNormal)
        {
            SceneManager.LoadScene(level3Normal);
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level3Hard);
        }
    }
    public void LoadLevelFour()
    {
        if (Dificulty.isNormal)
        {
            SceneManager.LoadScene(level4Normal);
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level4Hard);
        }
    }
    public void LoadLevelFive()
    {
        if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level5Hard);
        }
    }
    public void LoadLevelSix()
    {
        if (Dificulty.isHard)
        {
            SceneManager.LoadScene(level6Hard);
        }
    }
    public void LoadHowToPlay()
    {
        SceneManager.LoadScene(howToPlay);
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene(credits);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");

    }
}
