using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao3 : MonoBehaviour
{
    public GameObject porta;
    public GameObject player;
    public Animator animatorB;
    // Use this for initialization
    void Start()
    {
        porta.gameObject.SetActive(false);
    }
    void Update()
    {
        animatorB = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (player != null && other.gameObject.tag == player.gameObject.tag)
        { //coloca a tag player1 no player1
            animatorB.SetBool("EmcimaBotaoAzul", true);
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
            animatorB.SetBool("EmcimaBotaoAzul", false);
            if (porta != null)
            {

                porta.gameObject.SetActive(false);
               
            }

        }
    }
}