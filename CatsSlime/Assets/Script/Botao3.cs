using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao3 : MonoBehaviour
{
    public GameObject porta;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        porta.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (player != null && other.gameObject.tag == player.gameObject.tag)
        { //coloca a tag player1 no player1

            if (porta != null)
            {


                porta.gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (player != null && other.gameObject.tag == player.gameObject.tag)
        { //coloca a tag player1 no player1

            if (porta != null)
            {

                porta.gameObject.SetActive(false);
               
            }

        }
    }
}