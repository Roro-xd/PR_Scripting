using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{


    GameObject audioManagerObj;
    AudioManager audioManagerScript;

    //Hago una clase para la puntuación porque de otras maneras me está dando muchos problemas
    //Menciono el string que aparecerá en el texto UI
    string puntuacion;




    void Start()
    {
        audioManagerObj = GameObject.Find("AudioManagerObj");
        audioManagerScript = audioManagerObj.GetComponent<AudioManager>();
    }

    void Update()
    {
        //String e int no pueden ir juntos; creo una variable para obtener el dato de la puntuación
        int punt = (GameManager.vidas*10) + (GameManager.score*10) + (GameManager.enemigosMatados*10);
        //Transformo el dato int en string (con el nombre antes establecido)
        puntuacion = punt.ToString();

        //Modifico el texto UI que hay en el archivo
        this.GetComponent<TextMeshProUGUI>().text = puntuacion;
    }

    public void VictoriaExit() {
        Application.Quit();
    }

}
