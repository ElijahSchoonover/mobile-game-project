using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.5f;
    //public float speedBuff = 3f;
    public Joystick joystick;
    float horizontalMove;
    float verticalMove;
    //public AudioClip potionDrink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float xInput = Input.GetAxisRaw("Horizontal");
        
        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = 1f;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMove = -1f;
        }
        else
        {
            horizontalMove = 0f;
        }

        if (joystick.Vertical >= .2f)
        {
            verticalMove = 1f;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            verticalMove = -1f;
        }
        else
        {
            verticalMove = 0f;
        }
        // Debug.Log(xInput);

        //float yInput = Input.GetAxisRaw("Vertical");
        //GetComponent<Animator>().SetFloat("xInput", xInput);
        //GetComponent<Animator>().SetFloat("yInput", yInput);

        Vector2 moveDirection = new Vector2(horizontalMove, verticalMove);

        GetComponent<Rigidbody2D>().velocity = moveDirection * speed;
       
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*string otherTag = collision.gameObject.tag;
        if (otherTag == "SpeedPowerUp")
        {
            speed += speedBuff;
            Destroy(collision.gameObject);
            //GetComponent<AudioSource>().PlayOneShot(potionDrink);
        }
        if (otherTag == "DamagePowerUp")
        {
            EnemyHealth.damageAmount += 2;
            Destroy(collision.gameObject);
            //GetComponent<AudioSource>().PlayOneShot(potionDrink);
        }*/
    }
}
