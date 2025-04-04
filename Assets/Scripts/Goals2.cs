using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals2 : MonoBehaviour
{

    private Animator animatorMoneda;
    public int valorMonedaVariante = 3;
    void Start()
    {
        animatorMoneda = this.GetComponent<Animator>();
    }

    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player"){
            animatorMoneda.SetBool("Moneda_Var_Cogida", true);
            Destroy(this.gameObject, 1.5f);
            GameManager.score = GameManager.score+valorMonedaVariante;
            Debug.Log("He conseguido tres puntos!");
            Debug.Log("Puntos: "+GameManager.score);
        }

    }

}
