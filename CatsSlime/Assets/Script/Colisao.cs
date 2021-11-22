using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D outro)
	{
		if (outro.gameObject.tag == "player1") {
			GetComponent <Rigidbody2D> ().gravityScale = 1.0f;
		}
	}
}
