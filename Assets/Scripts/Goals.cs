using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{

    private Animator animatorMoneda;
    public int valorMoneda = 1;

    //Para el sonido
    GameObject AudioManagerObj;


    void Start()
    {
        animatorMoneda = this.GetComponent<Animator>();
        AudioManagerObj = GameObject.Find("AudioManagerObj");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player"){

            if (valorMoneda == 1) {
                animatorMoneda.SetBool("Moneda_Cogida", true);
            } else {
                animatorMoneda.SetBool("Moneda_Var_Cogida", true);
            }
            
            Destroy(this.gameObject, 1.5f);
            GameManager.score = GameManager.score+valorMoneda;

            //AudioManagerObj.GetComponent<AudioManager>().SuenaMoneda();
            AudioManager.Instance.SuenaClip(AudioManager.Instance.sonidoMoneda);

            if (valorMoneda == 1) {
                Debug.Log("He conseguido " + valorMoneda + " punto!");
            } else {
                Debug.Log("He conseguido " + valorMoneda + " puntos!");
            }

            Debug.Log("Puntos: "+GameManager.score);
        }

    }

}
