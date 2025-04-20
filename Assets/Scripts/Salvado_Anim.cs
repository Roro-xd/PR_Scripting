using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvado_Anim : MonoBehaviour
{

    private Animator animatorControllerSalvar;

    AudioSource salvarAudioManager;

    void Start()
    {
        animatorControllerSalvar = this.GetComponent<Animator>();
        animatorControllerSalvar.SetBool("Salvar_Ahora", false);
        salvarAudioManager = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void AnimSalvar() {
        animatorControllerSalvar.SetBool("Salvar_Ahora", true);
        salvarAudioManager.PlayOneShot(AudioManager.Instance.sonidoSave);
        //Destroy(this.gameObject, 1.5f);
    }
}
