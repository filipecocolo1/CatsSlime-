using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamerController : MonoBehaviour {
	public GameObject[] jogadores = new GameObject[2];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < jogadores.Length; i++) {
			if (!jogadores [i]) {
			
				SceneManager.LoadScene (SceneManager.GetActiveScene().name);
			
			}
		}
	}
}
