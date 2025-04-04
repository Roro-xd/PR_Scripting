using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    /*APUNTES. Variables que se han utilizado como prueba y al final no se emplean en el juego:
    --- CAMBIO DE COLOR 1 (establezco la clase)
    public Color miColor;
    */


    //MOVIMIENTO 1 (establezco la posición incial [sí o sí mediante un vector] / ACTUALIZADO: con respawn
    GameObject spawn;


    //CUERPO SÓLIDO 1 (menciono la clase para rigidbody)
    private Rigidbody2D rigBod;


   //SALTO 1 (creo un multiplicador para el salto; var booleana para evitar saltos continuos)
    public float multSalto = 5f;
    private bool puedoSaltar = true;
    public bool direccionBalaDcha = true;


    //ANIMACIÓN 1 (localizo y denomino al controlador de animación del personaje)
    private Animator animatorControllerMaga;


    //VELOCIDAD 1 (establezco la variable; es modificable durante el play)
    //public float vel = 0.1f;
    public float mult = 4f;
   




    void Start()
    {
        
        /*MOVIMIENTO 2 (aclaro que la posición inicial se modificará) /
        ACTUALIZADO: localizo el respawn y lo establezco como posición inicial*/
        spawn = GameObject.Find("Respawn");
        transform.position = spawn.transform.position;


        //CUERPO SÓLIDO 2 (vincular la clase a la propiedad del personaje para que tenga acceso a ella)
        rigBod = GetComponent<Rigidbody2D>();


        //ANIMACIÓN 2 (acceder a las propiedades en Unity)
        animatorControllerMaga = this.GetComponent<Animator>();

    }




    void Update()
    {

        //
        float miDeltaTime = Time.deltaTime;

        
        //El GameManager detecta cuándo estoy muerto; en este caso, el personaje se deja de mover (no sigue leyendo el Update)
        if(GameManager.estoyMuerto) return;


        /*APUNTES. Acciones que al final no se emplean en el juego:
    --- CAMBIO DE COLOR 2 (para poder modificar el color, accedo a las propiedades)
        this.GetComponent<SpriteRenderer>().color = miColor;
        */


        /*MOVIMIENTO 3: FORMA MÁS EXTENSA --- AUNQUE NO LO USE LO DEJO COMO APUNTE POR SI ME INTERESA CONSULTARLO EN ALGÚN MOMENTO

            ·Establecimiento de variable de posición actual:
                ---float posActual =  this.GetComponent<Transform>().position.x;

            ·"this.GetComponent<Transform>().position" es igual que "transform.position"; FORMA MÁS SENCILLA:
                ---transform.position = new Vector3 (posActual+0.01f, -0.5f, 0); 

            ·También puede rotar. "Debug.Log" es para ver el valor durante los cambios. "transform.Rotate('x','y','z')":
                ---Debug.Log(transform.rotation);
                ---transform.Rotate(0, 0, velocidad);*/





         /*MOVIMIENTO 4 (enlace del movimiento al input; "transform.position" y "transform.Translate" son casi iguales
        if(Input.GetKey(KeyCode.A)){ //Ir a la izquierda

            transform.Translate(vel*-1, 0, 0); //Movimiento hacia la izq
            this.GetComponent<SpriteRenderer>().flipX = true; //Girar sprite, para ir acorde al movimiento
            animatorControllerMaga.SetBool("activaWalk", true); //Activar animación Walk_Maga

        } else if(Input.GetKey(KeyCode.D)){ //Ir a la derecha

            transform.Translate(vel, 0, 0); //Movimiento hacia la dcha
            this.GetComponent<SpriteRenderer>().flipX = false; //No girar sprite, para ir acorde al movimiento
            animatorControllerMaga.SetBool("activaWalk", true); //Activar animación Walk_Maga

        } else {
            animatorControllerMaga.SetBool("activaWalk", false); //Desactivar animación Walk_Maga
        }*/




        //  OTRA FORMA MOV:
        float movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)

        rigBod.velocity = new Vector2(movTeclas*mult, rigBod.velocity.y);

        //izq
        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
            direccionBalaDcha = false;
        }else if(movTeclas > 0){ //der
            this.GetComponent<SpriteRenderer>().flipX = false;
            direccionBalaDcha = true;
        }

        //anim
        if(movTeclas !=0){
            animatorControllerMaga.SetBool("activaWalk", true);
        }else {
            animatorControllerMaga.SetBool("activaWalk", false);
        }





        /*CUERPO SÓLIDO 3 (coherencia de movimiento según el plano [terreno])
            ---rigBod.velocity = new Vector2(multSalto, rigBod.velocity.y);*/

        /*CUERPO SÓLIDO 4 (para que el personaje colisione con objetos + no pueda volver a saltar hasta que toque el SUELO;
        "Raycast('origen', 'dirección', 'magnitud, longitud')")*/
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.blue);

        if (hit){
            puedoSaltar = true;
            //Debug.Log(hit.collider.name);
        }else { 
            puedoSaltar = false;
        }

        /*CUERPO SÓLIDO 5 (cuando pulsamos SPACE, le hace efecto una fuerza;
        "AddForce('dirección' (vector de 2 valores solo), 'TipoDeFuerza' (impulso en nuestro caso))")*/
        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){ //Saltar
            rigBod.AddForce(new Vector2(0, multSalto), ForceMode2D.Impulse);
            puedoSaltar = false;
        }


        //Comprobar si me he salido de la pantalla (por debajo)
        if(transform.position.y <= -7){
            Respawnear();
        }


        // 0 vidas
        if(GameManager.vidas <= 0){
            GameManager.estoyMuerto = true;
        }

    }



    public void Respawnear(){

        //Si muere, que aparezca en el respawn
        transform.position = spawn.transform.position;

        //Si muere, que se le vayan restando vidas + que me avise el Console
        //Debug.Log("Vidas: "+GameManager.vidas);
        GameManager.vidas = GameManager.vidas -1;
        Debug.Log("Vidas: "+GameManager.vidas);
    }





    /*APUNTES: Funciones que al final no se emplean en el juego:
    ---GUI 1 (para ver el texto en la consola; es solo para probar el ratón)
    void OnGUI(){
        if (Event.current.isMouse && Event.current.button == 0){
            Debug.Log("awa");
        }
    }*/
}
