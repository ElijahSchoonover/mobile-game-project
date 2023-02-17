using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HowToPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReturnToLevelSelect()
    {
        if (Dificulty.isEasy == true)
        {
            SceneManager.LoadScene("Easy Level Select");
        }
        else if (Dificulty.isNormal == true)
        {
            SceneManager.LoadScene("Normal Level Select");
        }
        else if (Dificulty.isHard == true)
        {
            SceneManager.LoadScene("Hard Level Select");
        }
    }
}
