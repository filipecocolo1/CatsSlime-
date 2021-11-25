using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao2 : MonoBehaviour {
    public GameObject porta;
    public GameObject player;
    public GameObject player2;
    public Animator animatorB;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        animatorB = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == player.gameObject.tag || other.gameObject.tag == player2.gameObject.tag)
        { //coloca a tag player1 no player1
            animatorB.SetBool("EmcimaBotaoAzul", true);
            porta.gameObject.SetActive(false);
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == player.gameObject.tag || other.gameObject.tag == player2.gameObject.tag)
        { //coloca a tag player1 no player1
            animatorB.SetBool("EmcimaBotaoAzul", false);
            porta.gameObject.SetActive(true);

        }
    }
}

