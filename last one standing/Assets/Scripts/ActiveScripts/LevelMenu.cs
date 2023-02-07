using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public string level1;
    public string level2;
    public string level3;
    public string level4;
    public string level5;
    public string level6;
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
        SceneManager.LoadScene(level1);
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(level2);
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene(level3);
    }
    public void LoadLevelFour()
    {
        SceneManager.LoadScene(level4);
    }
    public void LoadLevelFive()
    {
        SceneManager.LoadScene(level5);
    }
    public void LoadLevelSix()
    {
        SceneManager.LoadScene(level6);
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
