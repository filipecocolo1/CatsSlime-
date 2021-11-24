using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rig;
    public bool isJump;
    public GameObject player;
    public GameObject player2;
    public Animator animator;
    public SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (player == true)
        {
            Move();
            Jump();
        }


        if (player2 == true)
        {
            Move2();
            Jump2();
        }
    }

    void Move()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        animator.SetBool("taCorrendo", false);
        float inputAxis = Input.GetAxis("Horizontal");

        if (inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);

            animator.SetBool("taCorrendo", true);
        }
        if (inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
            animator.SetBool("taCorrendo", true);
        }
    }
    void Jump()
    {

        if (Input.GetButtonDown("Jump") && !isJump)
        {
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }
    void Move2()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal2"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        animator.SetBool("taCorrendo2", false);


        float inputAxis = Input.GetAxis("Horizontal2");

        if (inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
            animator.SetBool("taCorrendo2", true);

        }
        if (inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
            animator.SetBool("taCorrendo2", true);
        }


    }

    void Jump2()
    {

        if ((Input.GetKeyUp(KeyCode.J) && !isJump))
        {
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }


    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);

        }

      
      
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "KillBlue")
        {
            Destroy(player2.gameObject);

        }
        if (collision.gameObject.tag == "KillOrange")
        {
            Destroy(player2.gameObject);

        }


    }
}


