using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassaDeFase : MonoBehaviour {

	public bool player1chegou;
	public bool player2chegou;
    public string proximaFase;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	
      void OnTriggerEnter2D (Collider2D other) {
        
       if (other.gameObject.CompareTag("player1")) {
			player1chegou = true;
		
        }
		if (other.gameObject.CompareTag ("player2")) {
			player2chegou = true; 
		}
		if (player1chegou == true && player2chegou == true) {
			SceneManager.LoadScene (proximaFase);
		
		}

	}
	void OnTriggerExit2D (Collider2D other) {

		if (other.gameObject.CompareTag("player1")) {
			player1chegou = false;

		}
		if (other.gameObject.CompareTag ("player2")) {
			player2chegou = false; 
		}

	}
}

