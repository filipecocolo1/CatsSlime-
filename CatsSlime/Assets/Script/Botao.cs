using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao: MonoBehaviour {

	public GameObject porta;
    public GameObject player;
	public GameObject caixa;
	public float recuoPressionar= 0.1f;
	public Vector3 posicaoOriginal;
    public Animator animatorB;

    //lembra de colocar rigibody e colocar o collider como trigger
    private void Update()
    {
        animatorB= GetComponent<Animator>();
    
    
    }
    void Awake () {
		posicaoOriginal = transform.position;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {


    
    
        if (player!= null && other.gameObject.tag == player.gameObject.tag){ //coloca a tag player1 no player1
            animatorB.SetBool("emCimabotao", true);
            animatorB.SetBool("EmcimaBotaoAzul", true);


            if (porta != null) {

            

                porta.gameObject.SetActive (false);

            

            }

        


            if (caixa != null) {
        
                caixa.gameObject.SetActive (false);



            }
        

        }
      

    }

        void OnTriggerExit2D(Collider2D other) {

     
        if (player!= null && other.gameObject.tag == player.gameObject.tag){ //coloca a tag player1 no player1

            animatorB.SetBool("emCimabotao", false);
            animatorB.SetBool("EmcimaBotaoAzul", false);
            if (porta != null) {

				porta.gameObject.SetActive (true);
                transform.position = posicaoOriginal;
            }

		}
    }
	/*void OnTriggerStay2D (Collider2D other)
    { //Para fazer o botão abaixar
        if (other.gameObject.tag == player.gameObject.tag)
           
       {
            transform.position = new Vector3(transform.position.x, transform.position.y - recuoPressionar, transform.position.z);
            
            if (transform.rotation.z == 0.0f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - recuoPressionar, transform.position.z);
            }
            else if (transform.rotation.z == -90.0f)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - recuoPressionar, transform.position.z);
            }
            else if (transform.rotation.z == 90.0f)
            {
                transform.position = new Vector3(transform.position.x +, transform.position.y - recuoPressionar, transform.position.z);
            }
            else if (transform.rotation.z == -180.0f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + recuoPressionar, transform.position.z);
            }
            */
        }
    


