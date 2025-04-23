using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victoria : MonoBehaviour
{
    private AudioSource audioVictoria;

//Para resetear la puntuación una vez estamos en la pantalla de victoria (por si se quiere volver a jugar)
    private GameObject GameManagerObj;
    private GameManager gameManagerScript;

    GameObject audioManagerObj;
    AudioManager audioManagerScript;


    void Start()
    {
        audioVictoria = this.GetComponent<AudioSource>();
        audioVictoria.PlayOneShot(AudioManager.Instance.sonidoGanar);

        GameManagerObj = GameObject.Find("GameManagerObj");
        gameManagerScript = GameManagerObj.GetComponent<GameManager>();

        audioManagerObj = GameObject.Find("AudioManagerObj");
        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();
    }

    void Update()
    {
        
    }


        public void VictoriaExit() {
        Application.Quit();
    }

    public void OtroPlay() {
        SceneManager.LoadScene("Start");
        gameManagerScript.ResetPuntuacion();
    }

    public void SuenaBoton(){
        audioManagerScript.miAudioSource.PlayOneShot(audioManagerScript.sonidoBoton);
    }

}
