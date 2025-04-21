using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
   private AudioSource audioVictoria;


    void Start()
    {

        audioVictoria = this.GetComponent<AudioSource>();
        audioVictoria.PlayOneShot(AudioManager.Instance.sonidoGanar);
    }

    void Update()
    {
        
    }

}
