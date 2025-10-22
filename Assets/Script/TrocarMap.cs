using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrocarMap : MonoBehaviour
{
    public string cena;
    public string cena2;
    public string cena3;
    public string cena4;
    public string cena5;
    public GameObject capitulos;
    public GameObject botoesmenu;

    public void Play()
    {
        SceneManager.LoadScene(cena);
    }

    public void Play2()
    {
        SceneManager.LoadScene(cena2);
    }
    
    public void Play3(){
        SceneManager.LoadScene(cena3);
    }
    public void Play4(){
        SceneManager.LoadScene(cena4);
    }
    public void Play5(){
        SceneManager.LoadScene(cena5);
    }

    public void OnMouseDown(){
        Application.Quit();
    }

    public void caps(){
        capitulos.SetActive(true);
        botoesmenu.SetActive(false);
    }
    public void voltarDoCaps(){
        capitulos.SetActive(false);
        botoesmenu.SetActive(true);

    }
}
