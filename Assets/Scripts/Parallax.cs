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
        //transform.position = new Vector3(camara.transform.position.x * velocidadParallax, 0, 0);
        transform.position = posInicial + camara.transform.position;
        transform.position = new Vector3(
            posInicial.x + (camara.transform.position.x * velocidadParallax),
            posInicial.y,
            0
         );
    }


    void FixedUpdate()
    {
        
    }
}
