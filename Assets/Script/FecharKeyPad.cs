using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FecharKeyPad : MonoBehaviour
{
    public GameObject keypad;

     public void Fechar()
     {
        Destroy(keypad);
     }
}
