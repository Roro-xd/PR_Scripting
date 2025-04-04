using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma_script : MonoBehaviour
{

    public int vidaFantasma = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if (vidaFantasma <= 0){
            Destroy(this.gameObject);
            GameManager.enemigosMatados += 1;
            Debug.Log("He matado a un enemigo!");
            Debug.Log("Enemigos matados: "+GameManager.enemigosMatados);
        }
    }
}
