using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseScreen : MonoBehaviour
{
    public int levelNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Restart()
    {
        if (Dificulty.isEasy)
        {
            SceneManager.LoadScene($"easy {levelNumber}");
        }
        else if (Dificulty.isNormal)
        {
            SceneManager.LoadScene($"normal {levelNumber}");
        }
        else if (Dificulty.isHard)
        {
            SceneManager.LoadScene($"Hard {levelNumber}");
        }
    }
}
