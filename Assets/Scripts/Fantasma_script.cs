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
        }
    }
}
