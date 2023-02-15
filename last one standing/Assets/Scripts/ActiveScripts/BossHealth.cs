using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BossHealth : MonoBehaviour
{
    public int health = 25;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "PlayerBullet" && Dificulty.isEasy == true)
        {
            health -= 4;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        if (otherTag == "PlayerBullet" && Dificulty.isNormal == true)
        {
            health -= 3;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        if (otherTag == "PlayerBullet" && Dificulty.isHard == true)
        {
            health -= 2;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
