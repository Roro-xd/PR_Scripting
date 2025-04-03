using System.Collections;
using System.Collections.Generic;
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
        //Debug.Log(col.name);
        animatorControllerSalvar.SetBool("Salvar_Ahora", true);
        //yield return new WaitForSeconds(1f);
        //Destroy(Salvar1);
    }
}
