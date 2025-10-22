using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta2 : MonoBehaviour
{
    public string proximaCena;

    private void OnMouseDown()
    {
        if (GameData.temChave3 == true)
        {
            Debug.Log("Porta aberta!");
            SceneManager.LoadScene(proximaCena);
        }
        else
        {
            Debug.Log("Você precisa de uma chave para abrir.");
        }
    }
    
}

