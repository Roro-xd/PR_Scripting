using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaFuego : MonoBehaviour
{

    public float velocidad = 4;
    private GameObject personaje;
    public int potenciaBalaFuego = 1;



    void Start()
    {
        personaje = GameObject.Find("Maga");

        if(personaje.GetComponent<MovPersonaje>().direccionBalaDcha == false){
            velocidad = velocidad*-1;
        }else if(personaje.GetComponent<MovPersonaje>().direccionBalaDcha == true){
            velocidad = velocidad*1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        float velocidadFinal = velocidad * Time.deltaTime;
        transform.Translate(velocidadFinal, 0f, 0f);

        Destroy(this.gameObject, 5f);

    }


    void OnTriggerEnter2D(Collider2D col){
        
        if(col.gameObject.name.StartsWith("Enemy_fantasma")){
            Destroy(this.gameObject);

            //fantasma
            col.gameObject.GetComponent<Fantasma_script>().vidaFantasma -= potenciaBalaFuego;
        }

    }

}
