using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    // Start is called before the first frame update
   
   
    public int numero1 = 10;
    public int numero2 = 80;
    public Vector3 posInicial = new Vector3(-1.75f, -0.5f, 0);
    public Color miColor; 



    void Start(){

         this.GetComponent<Transform>().position = posInicial;

         this.GetComponent<SpriteRenderer>().flipX = true;
         
    }



    void Awake(){



    }



    // Update is called once per frame
    void Update(){
        
        float posActual =  this.GetComponent<Transform>().position.x;
        this.GetComponent<Transform>().position = new Vector3 (posActual+0.01f, -0.5f, 0);

        this.GetComponent<SpriteRenderer>().color = miColor;




        int suma = Sumar(numero1,numero2);
        Debug.Log("La suma es: " + suma);
    }

    int Sumar(int numero1, int numero2){
        int resultado = numero1+numero2;
        return resultado;
    }


}
