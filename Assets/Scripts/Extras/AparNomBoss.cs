using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparNomBoss : MonoBehaviour
{

//Cuando el player cruza la zona marcada por este objeto vacío, se inicia la animación del boss y se destruye (para que no se
//repita cada vez que se vuelva a tocar)

    private GameObject finalBoss;
    private FinalBoss finalBossScript;


    void Start()
    {
        finalBoss = GameObject.Find("Enemy_Fantasma_Alter");
        finalBossScript = finalBoss.GetComponent<FinalBoss>();
    }

    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            finalBossScript.AnimNomBoss();
            Destroy(this.gameObject);
        }
    }
}
