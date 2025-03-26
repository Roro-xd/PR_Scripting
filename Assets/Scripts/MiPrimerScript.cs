using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//ESTÁ DESACTIVADO EN EL PERSONAJE DE UNITY PARA QUE NO ME MOLESTE EL TEXTO MIENTRAS TRATO DE HACER LAS PRÁCTICAS
public class MiPrimerScript : MonoBehaviour
{
    //Prueba de poner mi nombre (1: cración del string [la referencia])
    public string miNombre = "roro";

    //Prueba de hacer operaciones (1: creación de las variables)
    //"Public" nos sirve para poder modificar los valores desde Unity durante el play
    public int numero1 = 10;
    public int numero2 = 80;


    void Start()
    {

    }



    void Update()
    {
        
        //Prueba de poner mi nombre (2: representación del string)
        Debug.Log("Hola, mi nombre es "+miNombre);

        //Prueba de hacer operaciones (2: variable de la operación y representación)
        int suma = Sumar(numero1,numero2);
        Debug.Log("La suma es: " + suma);

    }



    //Prueba de hacer operaciones (3: variable "Sumar" y establecimiento de resultado)
    int Sumar(int numero1, int numero2){
        int resultado = numero1+numero2;
        return resultado;
    }

}