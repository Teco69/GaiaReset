using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarChave : MonoBehaviour
{
    public GameObject other;
     private void OnMouseDown()
    {
        GameData.temChave = true;
        Destroy(gameObject); // Remove a chave da cena
        other.SetActive(true);
        Debug.Log("Chave coletada!");

    }

    //GameData.temChave = true; usar na segunda chave
}