using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int health = 25;
    public string sceneName;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "PlayerBullet" && Dificulty.isEasy == true)
        {
            health -= 4;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        if (otherTag == "PlayerBullet" && Dificulty.isNormal == true)
        {
            health -= 3;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        if (otherTag == "PlayerBullet" && Dificulty.isHard == true)
        {
            health -= 2;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
