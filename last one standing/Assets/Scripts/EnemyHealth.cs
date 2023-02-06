using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject enemy;
    public static int damageAmount = 2;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "PlayerBullet")
        {
            health -= damageAmount;
            slider.value = health;
            if (health <= 0)
            {
                Destroy(enemy);
                Debug.Log("Enemy Killed");
            }
        }
    }
}
