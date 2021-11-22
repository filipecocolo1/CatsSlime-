using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Espinho : MonoBehaviour {
	public float a;
	public float b;
    //PingPong
    void Start() {
		//transform.position = new Vector3 (1.38f ,  transform.position.y, transform.position.z);
    }

    // Update is called once per frame

    void Update()
	{
		transform.position = new Vector2 (a * (Mathf.Sin (Mathf.PI * Time.time))-b , transform.position.y);

	}
    
}



