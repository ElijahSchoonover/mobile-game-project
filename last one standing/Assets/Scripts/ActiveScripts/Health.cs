using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;
public class Health : MonoBehaviour
{
    public float health = 10.0f;
    public Slider slider;
    //public int maxHealth = 10;
    //public TextMeshProUGUI healthText;
    //public int healing = 4;
    // name of the lose screen
    public string sceneName;
    // Start is called before the first frame update
    //public AudioClip potionDrink;
    void Start()
    {
        if (Dificulty.isEasy == true)
        {
            health *= 1.5f;
            health = MathF.Ceiling(health);
        }
        else if (Dificulty.isHard == true)
        {
            health *= 0.75f;
            health = MathF.Ceiling(health);
        }
        slider.maxValue = health;
        slider.value = health;
    }
    // Update is called once per frame
    void Update()
    {
        //healthText.text = $"Health: {health}";
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "DamageTag" && Dificulty.isNormal == true)
        {
            health -= 3;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else if (otherTag == "DamageTag" && Dificulty.isEasy == true)
        {
            health -= 2;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else if (otherTag == "DamageTag" && Dificulty.isHard == true)
        {
            health -= 4;
            slider.value = health;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        if (otherTag == "Killbox")
        {
            SceneManager.LoadScene(sceneName);
        }
        /*else if (otherTag == "HealingPowerUp")
        {
            health += healing;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(potionDrink);
            if (health > maxHealth)
            {
                health = maxHealth;
                
            }
        }*/
    }
}

