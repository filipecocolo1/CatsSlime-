using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChek : MonoBehaviour
{
    PlayerMoviment Player;


    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<PlayerMoviment>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Player.isJump = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
         if (collision.gameObject.layer == 6)
        {
            Player.isJump = true;
        }
    }

}
