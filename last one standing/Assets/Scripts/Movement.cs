using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.5f;
    public float speedBuff = 3f;
    public AudioClip potionDrink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        // Debug.Log(xInput);

        float yInput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("xInput", xInput);
        GetComponent<Animator>().SetFloat("yInput", yInput);

        Vector2 moveDirection = new Vector2(xInput, yInput);

        GetComponent<Rigidbody2D>().velocity = moveDirection * speed;
       
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "SpeedPowerUp")
        {
            speed += speedBuff;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(potionDrink);
        }
        if (otherTag == "DamagePowerUp")
        {
            EnemyHealth.damageAmount += 2;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(potionDrink);
        }
    }
}
