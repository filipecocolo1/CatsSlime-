using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {

	public GameObject porta;
    public GameObject player; 


    //lembra de colocar rigibody e colocar o collider como trigger
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == player.gameObject.tag){ //coloca a tag player1 no player1
			
			porta.gameObject.SetActive(false);

        }
	}
}
