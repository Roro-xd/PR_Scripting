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
    public float velocidad = 0.01f;



    void Start(){

        transform.position = posInicial;

        //this.GetComponent<SpriteRenderer>().flipX = true;
         
    }



    void Awake(){



    }



    // Update is called once per frame
    void Update(){
        
       //float posActual =  this.GetComponent<Transform>().position.x;

        //this.GetComponent<Transform>().position es = a transform.position
        //transform.position = new Vector3 (posActual+0.01f, -0.5f, 0); 

       //transform.Translate(velocidad, 0, 0);

       //Debug.Log(transform.rotation);
      //transform.Rotate(0, 0, velocidad);
        
        //this.GetComponent<SpriteRenderer>().color = miColor;

        if(Input.GetKey(KeyCode.A)){ //Ir a la izquierda
            transform.Translate(velocidad*-1, 0, 0);
        }

        if(Input.GetKey(KeyCode.D)){ //Ir a la derecha
            transform.Translate(velocidad, 0, 0);
        }



        //int suma = Sumar(numero1,numero2);
        //Debug.Log("La suma es: " + suma);
    }




    void OnGUI(){

        if (Event.current.isMouse && Event.current.button == 0){
            Debug.Log("awa");
        }

    }





    //int Sumar(int numero1, int numero2){
        //int resultado = numero1+numero2;
        //return resultado;
    //}


}
