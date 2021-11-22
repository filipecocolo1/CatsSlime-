using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 200.0f;
    public float jumpForce = 100.0f;
    public string inputHorizontal = "HORIZONTAL0";
    public string inputJump = "AZUL0";
    public string playerColor = "Blue";
    public Vector2 spawnPosition = new Vector2(-4.74f, 2.34f);
    public Animator animator;
    public Rigidbody2D myRigidBody;
    public SpriteRenderer mySpriteRenderer;
    public bool isGrounded = false;

    public AudioSource audio;


    void FixedUpdate()
    {

        if (Input.GetButtonDown(inputJump) && isGrounded)
        {
            myRigidBody.AddForce(transform.up * jumpForce);

            audio.Play();
        }

        Vector2 velocity = myRigidBody.velocity;
        velocity.x = Input.GetAxis(inputHorizontal) * Time.fixedDeltaTime * playerSpeed;
        myRigidBody.velocity = velocity;

        if (myRigidBody.velocity.x == 0)
        {
            animator.Play("Parado1");
        }
        else
        {

            animator.Play("Andando1");
            if (myRigidBody.velocity.x > 0)
            {
                mySpriteRenderer.flipX = false;

            }
            else
            {

                mySpriteRenderer.flipX = true;
            }
        }


    }
    void Start()
    {

        myRigidBody = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();

    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Chao")
        {
            isGrounded = true;

        }
        if (col.gameObject.tag == "KillBlue" && playerColor == "Blue")
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "KillOrange" && playerColor == "Orange")
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Chao")
        {
            isGrounded = false;
            CancelInvoke("OnGround");
            Invoke("OnGround", 2);

        }
    }

    void OnGround()
    {
        isGrounded = true;

    }
}

