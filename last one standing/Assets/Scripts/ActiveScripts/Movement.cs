using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Movement : MonoBehaviour
{
    public float speed = 2.5f;
    //public float speedBuff = 3f;
    public Joystick joystick;
    float horizontalMove;
    float verticalMove;
    public float deadZoneSize;
    //public AudioClip potionDrink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        
        if (joystick.Horizontal >= deadZoneSize)
        {
            horizontalMove = 1f;
        }
        else if (joystick.Horizontal <= -deadZoneSize)
        {
            horizontalMove = -1f;
        }
        else
        {
            horizontalMove = 0f;
        }

        if (joystick.Vertical >= deadZoneSize)
        {
            verticalMove = 1f;
        }
        else if (joystick.Vertical <= -deadZoneSize)
        {
            verticalMove = -1f;
        }
        else
        {
            verticalMove = 0f;
        }
        // Debug.Log(xInput);

        float yInput = Input.GetAxisRaw("Vertical");
        //GetComponent<Animator>().SetFloat("xInput", xInput);
        //GetComponent<Animator>().SetFloat("yInput", yInput);

        Vector2 moveDirection = new Vector2(horizontalMove, verticalMove);
        //Vector2 pCMoveDirection = new Vector2(xInput, yInput);
        GetComponent<Rigidbody2D>().velocity = moveDirection * speed;
        //GetComponent<Rigidbody2D>().velocity = pCMoveDirection * speed;
       
        
        
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
