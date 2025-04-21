using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public AudioSource miAudioSource;
    public AudioClip bandaSonora;
    public AudioClip sonidoMoneda;
    public AudioClip sonidoFantasma;
    public AudioClip sonidoArma;
    public AudioClip sonidoMuerte;
    public AudioClip sonidoMatar;
    public AudioClip sonidoSave;
    public AudioClip sonidoSaltar;
    public AudioClip sonidoGameOver;
    public AudioClip sonidoGanar;
    public AudioClip sonidoBoton;

    public static AudioManager Instance;





    void Start()
    {
        miAudioSource = GetComponent<AudioSource>();
        miAudioSource.clip = bandaSonora;
        miAudioSource.Play();
        
    }



    void Update()
    {
        
    }



    void Awake() {

        //Para que no se solapen reproducciones con cosas que suceden en Start()
        if (Instance != null && Instance != this){
            Destroy(this.gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }



    public void SuenaMoneda() {
        miAudioSource.PlayOneShot(sonidoMoneda);
    }

    public void SuenaFantasma() {
        miAudioSource.PlayOneShot(sonidoFantasma);
    }


    public void SuenaClip(AudioClip miClipDeAudio) {
        miAudioSource.PlayOneShot(miClipDeAudio);
    }

    public void SuenaGanar() {
        miAudioSource.PlayOneShot(sonidoGanar);
    }
}
