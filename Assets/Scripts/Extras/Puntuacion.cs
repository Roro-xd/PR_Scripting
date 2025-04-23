using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Puntuacion : MonoBehaviour
{

    //Hago una clase para la puntuación; menciono el string que aparecerá en el texto UI
    string puntuacion;


    void Start()
    {

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


}
