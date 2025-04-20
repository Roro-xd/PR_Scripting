using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{

    private Animator animatorNombreBoss;

    GameObject panelWin;
    GameObject puntuacionScript;
    GameObject boxVolume;
    int puntuacion = 0;


    void Start()
    {
        animatorNombreBoss = this.GetComponent<Animator>();

        panelWin = GameObject.Find("Panel_Win");
        panelWin.SetActive(false);

        puntuacionScript = GameObject.Find("PuntuacionScript");

        boxVolume = GameObject.Find("Box Volume");
    }

    void Update()
    {
               
    }


    public void AnimNomBoss() {
        animatorNombreBoss.SetBool("NombreBoss", true);
    }

    public void Win() {

        boxVolume.SetActive(false);
        panelWin.SetActive(true);
        puntuacion = GameManager.vidas + GameManager.score + GameManager.enemigosMatados;
        puntuacionScript.GetComponent<TextMeshProUGUI>().text = puntuacion.ToString();
    }
}
