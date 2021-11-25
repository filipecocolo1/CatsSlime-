using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao4 : MonoBehaviour
{
    public GameObject caixa;
    public GameObject player;
    public GameObject laser;
    public Animator animatorB;
    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        animatorB = GetComponent<Animator>();
    }
    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {

        if (player != null && other.gameObject.tag == player.gameObject.tag)
        { //coloca a tag player1 no player1
            animatorB.SetBool("EmcimaBotaoAzul",true );
            if (laser != null)
            {
             

                laser.gameObject.SetActive(false);
            }
            if (caixa != null)
            {
               
                caixa.gameObject.SetActive(false);
            }

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {


        if (laser != null)
        {
            animatorB.SetBool("EmcimaBotaoAzul", false);

        }
        if (caixa != null)
        {
            animatorB.SetBool("EmcimaBotaoAzul", false);

        }





    }
}