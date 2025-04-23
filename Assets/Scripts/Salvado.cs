using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Salvado : MonoBehaviour
{

//Para los distintos spawns según los guardados por los que se ha pasado (seguro que hay una forma más eficiente, pero la no sé
//ni la he encontrado)
    GameObject Respawn;
    GameObject Respawn2;
    GameObject Respawn3;

//Para los avisos al guardar
    private GameObject gameManagerObj;
    private GameManager gameManagerScript;

//Para el sonido al guardar
    private GameObject sonidoSalvar;
    AudioSource salvarAudioManager;



    


    void Start()
    {
        Respawn = GameObject.Find("Respawn");
        Respawn2 = GameObject.Find("Respawn2");
        Respawn3 = GameObject.Find("Respawn3");

        gameManagerObj = GameObject.Find("GameManagerObj");
        gameManagerScript = gameManagerObj.GetComponent<GameManager>();

        sonidoSalvar = GameObject.Find("SonidoSalvado");
        salvarAudioManager = sonidoSalvar.GetComponent<AudioSource>();

    }



    void Update()
    {
        
    }


    
    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.tag == "Player"){
            if(this.gameObject.name == "Salvar1"){
                Respawn.transform.position = Respawn2.transform.position;
            }

            if(this.gameObject.name == "Salvar2"){
                Respawn.transform.position = Respawn3.transform.position;
            }


            GameManager.vidas = GameManager.vidas+1;
            gameManagerScript.AvisoSalvar();

            salvarAudioManager.PlayOneShot(AudioManager.Instance.sonidoSave);

            //Debug.Log("He conseguido una vida!");
            //Debug.Log("Vidas: "+GameManager.vidas);
            Destroy(this.gameObject);
        
            
        }

        
    }
}
