using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Derrota : MonoBehaviour
{

    private AudioSource audioDerrota;

    GameObject audioManagerObj;
    AudioManager audioManagerScript;

    void Start()
    {
        audioDerrota = this.GetComponent<AudioSource>();
        audioDerrota.PlayOneShot(AudioManager.Instance.sonidoGameOver);  

        audioManagerObj = GameObject.Find("AudioManagerObj");
        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();
    }

    void Update()
    {
        
    }


    public void OtroPlay() {
        SceneManager.LoadScene("Start");
    }


    public void SuenaBoton(){
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoBoton);
    }

    public void DerrotaExit() {
        Application.Quit();
    }
}
