using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma_script : MonoBehaviour
{

    public int vidaFantasma = 5;
    public float velocidad = 1.5f;
    public float limiteDcha = 3;
    public float limiteIzq = 3;

    private Vector3 posLimitDcha;
    private Vector3 posLimitIzq;

    private bool dirFantasmaDcha = true;

    private Vector3 posInicial;

    private string estadoFantasma = "Patrol";

    private GameObject player;

    private float distancia;
    public float distanciaAtaque = 3;
    public float velocidadAtaque = 2;
    public float distanciaPatrol = 5;

    private MovPersonaje respawnear;

    void Start()
    {
        posInicial = transform.position;
        posLimitDcha = posInicial + new Vector3(limiteDcha, posInicial.y, 0);
        posLimitIzq = posInicial - new Vector3(limiteIzq, posInicial.y, 0);

        this.GetComponent<SpriteRenderer>().flipX = true;

        player = GameObject.FindWithTag("Player");

        respawnear = player.GetComponent<MovPersonaje>();
    }

    void Update()
    {
        //CONTROL DE VIDA DEL FANTASMA
        if (vidaFantasma <= 0)
        {
            Destroy(this.gameObject);
            GameManager.enemigosMatados += 1;
            Debug.Log("He matado a un enemigo!");
            Debug.Log("Enemigos matados: " + GameManager.enemigosMatados);
        }



        //CÁLCULO DE LA DISTANCIA ENEMIGO-PLAYER
        distancia = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(distancia + "****" + estadoFantasma);

        if (distancia <= distanciaAtaque) {
            estadoFantasma = "Ataque";
        }

        if (distancia >= distanciaPatrol) {
            estadoFantasma = "Patrol";
        }


        //////////////////
        /////"PATROL"/////
        //////////////////
        if (estadoFantasma == "Patrol") {
            //MOVIMIENTO DEL FANTASMA
                //DESPLAZAMIENTO
            if (dirFantasmaDcha == true)
            {
                transform.Translate(velocidad * Time.deltaTime, 0, 0); //Ir hacia la derecha
            }

            if (dirFantasmaDcha == false)
            {
                transform.Translate((velocidad * Time.deltaTime) * -1, 0, 0); //Ir hacia la izquierda
            }


                //CAMBIO DE LA BOOL Y FLIP
            if (transform.position.x >= posLimitDcha.x)
            { //Si llega al límite...
                dirFantasmaDcha = false; //...imposibilitar el movimiento hacia la derecha (y cambiarlo)
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (transform.position.x <= posLimitIzq.x)
            { //Si llega al límite...
                dirFantasmaDcha = true; //...imposibilitar el movimiento hacia la izquierda (y cambiarlo)
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
        }



        //////////////////
        /////"ATAQUE"/////
        //////////////////
        if (estadoFantasma == "Ataque") {
            transform.position = Vector3.MoveTowards(
                transform.position, player.transform.position, velocidadAtaque * Time.deltaTime
            );

            if(player.transform.position.x <= transform.position.x) {
                this.GetComponent<SpriteRenderer>().flipX = false;
            } else {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
        }



    }


    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
              //GameManager.vidas -= 1;
              respawnear.Respawnear();
        }
    }


    
}
