using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dificulty : MonoBehaviour
{
    public static bool isEasy = false;
    public static bool isNormal = true;
    public static bool isHard = false;
    public string easySceneName;
    public string normalSceneName;
    public string hardSceneName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EasyMode()
    {
        isEasy = true;
        isNormal = false;
        isHard = false;
        SceneManager.LoadScene(easySceneName);
        Debug.Log("Easy");

    }
    public void NormalMode()
    {
        isEasy = false;
        isNormal = true;
        isHard = false;
        SceneManager.LoadScene(normalSceneName);
        Debug.Log("Normal");
    }
    public void HardMode()
    {
        isEasy = false;
        isNormal = false;
        isHard = true;
        SceneManager.LoadScene(hardSceneName);
        Debug.Log("Hard");
    }
}
