using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void JogarButton (string CenaJogo)
    {

        SceneManager.LoadScene(CenaJogo);
    }
    public void ControlesButton (string CenaControle)
    {
        SceneManager.LoadScene(CenaControle);
    }

    public void SobreButton(string CenaSobre)
    {
        SceneManager.LoadScene(CenaSobre);
    }

    public void VoltarButton (string MenuCena)
    {
        SceneManager.LoadScene(MenuCena);
    }

    public void SimButton(string CenaJogo)
    {
        SceneManager.LoadScene(CenaJogo);
    }

    public void NaoButton(string MenuCena)
    {
        SceneManager.LoadScene(MenuCena);
    } 

    public void SairButton()
    {
        Application.Quit();
    }

        
}
    // Use this for initialization




