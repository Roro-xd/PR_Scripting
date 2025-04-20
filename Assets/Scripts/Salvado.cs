using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Salvado : MonoBehaviour
{

    GameObject Respawn;
    GameObject Respawn2;
    GameObject Respawn3;
    private Animator animatorControllerSalvar;

    private GameObject gameManagerObj;
    private GameManager gameManagerScript;

    AudioSource salvarAudioManager;

    private GameObject nomBoss;
    private FinalBoss finalBossScript;


    


    void Start()
    {
        Respawn = GameObject.Find("Respawn");
        Respawn2 = GameObject.Find("Respawn2");
        Respawn3 = GameObject.Find("Respawn3");
        animatorControllerSalvar = this.GetComponent<Animator>();

        gameManagerObj = GameObject.Find("GameManagerObj");
        gameManagerScript = gameManagerObj.GetComponent<GameManager>();

        salvarAudioManager = this.GetComponent<AudioSource>();

        nomBoss = GameObject.Find("NombreFinalBoss");
        finalBossScript = nomBoss.GetComponent<FinalBoss>();

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
                finalBossScript.AnimNomBoss();
            }

            animatorControllerSalvar.SetBool("Salvar_Ahora", true);
            GameManager.vidas = GameManager.vidas+1;

            gameManagerScript.AvisoSalvar();

            //He cambiado el sonido fx_coin por el de fx_save porque creo que quedan mejor al revés
            salvarAudioManager.PlayOneShot(AudioManager.Instance.sonidoSave);

            Debug.Log("He conseguido una vida!");
            Debug.Log("Vidas: "+GameManager.vidas);
            Destroy(this.gameObject, 1.5f);
        
            
        }

        
    }
}
