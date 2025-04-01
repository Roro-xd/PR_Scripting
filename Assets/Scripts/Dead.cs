using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour{


private GameObject personaje;
private MovPersonaje movPersonaje;


    void Start()
    {
        //Localizo al personaje
        personaje = GameObject.Find("Maga");
        //Localizo el script al que referirme para respawnear después al personaje
        movPersonaje = personaje.GetComponent<MovPersonaje>();
    }



    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        
        //Si el personaje mencionado colisiona con el objeto, respawnea
        if (col.name == "Maga"){
            movPersonaje.Respawnear();
        }

    }
}
