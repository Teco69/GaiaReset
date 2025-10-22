using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaSegura : MonoBehaviour
{
    public GameObject Cronometro1;
    public GameObject Cronometro2;
    public GameObject objetoParaDesativar; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {


            other.GetComponent<RadiationManager>().estaNaZonaSegura = true;
            objetoParaDesativar.SetActive(false);
            Cronometro1.SetActive(true);
            Cronometro2.SetActive(true);
            
        }

        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<RadiationManager>().estaNaZonaSegura = false;
        }
    }

    
}