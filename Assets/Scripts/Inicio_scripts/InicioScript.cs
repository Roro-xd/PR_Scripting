using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
 
    GameObject panelSettings;
    GameObject audioManagerObj;
    AudioManager audioManagerScript;

    void Start()
    {
        panelSettings = GameObject.Find("Panel_Settings");
        panelSettings.SetActive(false);

        audioManagerObj = GameObject.Find("AudioManagerObj");

        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();


    }

    
    void Update()
    {
        
    }


    //Decirle al código que cuando se presione el botón, nos lleve a otra escena
    public void InicioPlay() {
        //Debug.Log("ola");
        SceneManager.LoadScene("Scene1");
    }


    public void InicioSettings() {
        panelSettings.SetActive(true);
    }

    public void InicioExitSettings() {
        panelSettings.SetActive(false);
        
    }


    public void InicioExit() {
        Application.Quit();
    }


    public void SuenaBoton(){
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoMoneda);
    }

}
