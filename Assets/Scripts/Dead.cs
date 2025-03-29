using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour{


private GameObject personaje;
private Salto movPersonaje;


    // Start is called before the first frame update
    void Start()
    {

        personaje = GameObject.Find("idle1");
        movPersonaje = personaje.GetComponent<Salto>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OgerEnter2D(Collider2D col)
    {
        
        if (col.name == "idle1"){
            movPersonaje.Respawnear();
        }

    }
}
