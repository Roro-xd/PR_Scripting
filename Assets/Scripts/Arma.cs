using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    public GameObject balaFuego;


    void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E)){ //Para disparar

            //Instantiate(objeto, position, rotacion)
            Instantiate(balaFuego, transform.position, Quaternion.identity);
            //Debug.Log(" ");
        }

    }
}
