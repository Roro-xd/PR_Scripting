using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{

    private Animator animatorMoneda;
    public int valorMoneda = 1;


    void Start()
    {
        animatorMoneda = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player"){
            animatorMoneda.SetBool("Moneda_Cogida", true);
            Destroy(this.gameObject, 1.5f);
            GameManager.score = GameManager.score+valorMoneda;
            Debug.Log("He conseguido un punto!");
            Debug.Log("Puntos: "+GameManager.score);
        }

    }

}
