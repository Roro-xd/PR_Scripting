using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class InicioScript : MonoBehaviour
{
 
    GameObject panelSettings;
    GameObject audioManagerObj;
    AudioManager audioManagerScript;

    public Slider sliderSonido;



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
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoBoton);
    }


    //Relaciono el volumen con el slider
    public void VolumenMusica() {
        AudioListener.volume = sliderSonido.value;
    }

}
