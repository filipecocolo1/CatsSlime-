using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rig;
    public bool isJump;
    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        MovePlayer2();


    }

    void Move()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;


        float inputAxis = Input.GetAxis("Horizontal");

        if (inputAxis < 0) {
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        if (inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }


    }
    void Jump()
    {

        if (Input.GetButtonDown("Jump")&& !isJump)
        {
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }


    }

    void MovePlayer2()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal1"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;


        float inputAxis = Input.GetAxis("Horizontal1");

        if (inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        if (inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }


    }

}
