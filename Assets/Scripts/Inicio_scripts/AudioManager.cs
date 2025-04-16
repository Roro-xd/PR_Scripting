using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource miAudioSource;
    public AudioClip bandaSonora;
    public AudioClip sonidoMoneda;
    public AudioClip sonidoFantasma;

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

        //Para que no se sokapen reproducciones con cosas que suceden en Start()
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


    //Método para 
    public void SuenaClip(AudioClip miClipDeAudio) {
        miAudioSource.PlayOneShot(miClipDeAudio);
    }
}
