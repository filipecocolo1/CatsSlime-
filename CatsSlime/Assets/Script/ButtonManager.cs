using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void JogarButton()
    {

        SceneManager.LoadScene("Cena1");
    }
    public void ControlesButton()
    {
        SceneManager.LoadScene("Controles");
    }

    public void SobreButton()
    {
        SceneManager.LoadScene("Sobre");
    }

    public void VoltarButton()
    {
        SceneManager.LoadScene("Menu");
    }

  

    public void NaoButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SairButton()
    {
        Application.Quit();
    }

    public void Fase2()
    {
        SceneManager.LoadScene("Cena2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("Cena3");



    }


    public void Fase4()
    {
        SceneManager.LoadScene("Cena4");
    }
}
    // Use this for initialization




