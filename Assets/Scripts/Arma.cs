using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    public GameObject balaFuego;

    AudioSource armaAudioManager;


    void Start()
    {
        armaAudioManager = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E)){ //Para disparar

            //Instantiate(objeto, position, rotacion)
            Instantiate(balaFuego, transform.position, Quaternion.identity);
            armaAudioManager.PlayOneShot(AudioManager.Instance.sonidoArma);
        
        }

    }
}
