using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    bool grounded = false;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");

        Vector2 velocity = rb.velocity;
        velocity.x = xInput * moveSpeed;
        rb.velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
            animator.SetTrigger("Jump");
        }
        if (rb.velocity.y < -0.1f && !grounded)
        {
            animator.SetTrigger("Fall");
        }
        animator.SetFloat("xInput", xInput);
        animator.SetBool("grounded", grounded);
        if (xInput < 0)
        {
            spriteRenderer.flipX = false;
        }
        else if(xInput > 0)
        {
            spriteRenderer.flipX = true;
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                grounded = true;
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                grounded = false;
            }
        }
    public void Jump()
    {
        if (grounded == true)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
            animator.SetTrigger("Jump");
        }
        if (rb.velocity.y < -0.1f && !grounded)
        {
            animator.SetTrigger("Fall");
        }
        Debug.Log("Jump Successful");
        //animator.SetFloat("xInput", xInput);
        //animator.SetBool("grounded", grounded);
    }
    public void MoveLeft()
    {
        float xInput = -0.5f;
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = xInput * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        Debug.Log("success");
    }
    public void MoveRight()
    {

    }
}
