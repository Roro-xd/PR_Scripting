using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource miAudioSource;
    public AudioClip bandaSonora;
    public AudioClip sonidoMoneda;


    void Start()
    {
        miAudioSource = GetComponent<AudioSource>();
        miAudioSource.clip = bandaSonora;
        miAudioSource.Play();
    }

    void Update()
    {
        
    }
}
