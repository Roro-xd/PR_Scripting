using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Salvado : MonoBehaviour
{

    GameObject Respawn;
    GameObject Respawn2;
    private GameObject Salvar1;
    private Animator animatorControllerSalvar;

    void Start()
    {
        Respawn = GameObject.Find("Respawn");
        Respawn2 = GameObject.Find("Respawn2");
        Salvar1 = GameObject.Find("Salvar1");
        animatorControllerSalvar = this.GetComponent<Animator>();
    }



    void Update()
    {
        
    }


    
    void OnTriggerEnter2D(Collider2D col){
        Respawn.transform.position = Respawn2.transform.position;
        animatorControllerSalvar.SetBool("Salvar_Ahora", true);
        GameManager.vidas = GameManager.vidas+1;
        Debug.Log("He conseguido una vida!");
        Debug.Log("Vidas: "+GameManager.vidas);
        Destroy(Salvar1, 1.5f);
    }
}
