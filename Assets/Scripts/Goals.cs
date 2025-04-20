using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
    public int valorMoneda = 1;

    private GameObject gameManagerObj;
    private GameManager gameManagerScript;


    void Start()
    {
        gameManagerObj = GameObject.Find("GameManagerObj");
        gameManagerScript = gameManagerObj.GetComponent<GameManager>();
    }

    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        
        if(col.tag == "Player"){
            
            Destroy(this.gameObject);
            GameManager.score = GameManager.score+valorMoneda;

            //He cambiado el sonido fx_moneda por el de fx_save porque creo que quedan mejor al revés
            AudioManager.Instance.SuenaClip(AudioManager.Instance.sonidoMoneda);

            if (valorMoneda == 1) {
                //Debug.Log("He conseguido " + valorMoneda + " punto!");
                gameManagerScript.AvisoPunto();
            } else {
                //Debug.Log("He conseguido " + valorMoneda + " puntos!");
                gameManagerScript.AvisoPuntos();
            }

            //Debug.Log("Puntos: "+GameManager.score);
        }

    }

}
