using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinalBoss : MonoBehaviour
{

    //Aparición del nombre del boss: llamo al objeto del texto y a la animación de este
    GameObject nombreBoss;
    private Animator animatorNombreBoss;

    GameObject panelStats;



    void Start()
    {
        //Aparición del nombre del boss: encuentro los objetos
        nombreBoss = GameObject.Find("NombreFinalBoss");
        animatorNombreBoss = nombreBoss.GetComponent<Animator>();

        panelStats = GameObject.Find("Panel_Stats");

    }

    void Update()
    {
       
    }


    /*Creo un método para que la animación suceda cuando le diga. En este caso, para evitar que se repita,
    lo he relacionado con el segundo cambio de respawn [en script "Salvado"] (no aparecería en caso de no guardar,
    pero es la mejor forma que se me ha ocurrido para no complicarlo demasiado)*/
    public void AnimNomBoss() {
        //Aparición del nombre del boss: establezco la animación
        animatorNombreBoss.SetBool("NombreBoss", true);
        panelStats.SetActive(false);
    }

    public void Win() {
        //Una vez se derrota al final boss, se pasa a la pantalla de victoria
        SceneManager.LoadScene("Victoria");
    }
}
