using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevitatingPlatform: MonoBehaviour {
    public float a;
    public float b;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, a * (Mathf.Sin(Mathf.PI * Time.time)) - b);
    }
}
