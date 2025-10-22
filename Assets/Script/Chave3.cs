using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave3 : MonoBehaviour
{
    
    
     private void OnMouseDown()
    {
        GameData.temChave3 = true;
        Destroy(gameObject); // Remove a chave da cena
        Debug.Log("Chave coletada!");
        
    }

    
}