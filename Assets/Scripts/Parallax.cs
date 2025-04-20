using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;
    GameObject camara;
    public float velocidadParallax = 1;
    public Vector3 posInicial;



    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camara = GameObject.FindWithTag("MainCamera");
        posInicial = transform.position;
    }



   void Update()
    {
        
    }


    void FixedUpdate()
    {
       transform.position = new Vector3(Camera.main.transform.position.x / velocidadParallax, transform.position.y, 0);
    }
}
