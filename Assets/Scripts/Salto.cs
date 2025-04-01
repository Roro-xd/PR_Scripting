using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    //Movimiento (1: establezco la posición incial [sí o sí mediante un vector/ACTUALIZADO: Respawn])
    GameObject respawn;

    /*Cambio de color (1: establezco la clase del color)
    public Color miColor;*/

    //Variación de velocidad (establezco la variable; es modificable durante el play)
    public float velocidad = 0.1f;

    /*Cuerpo sólido (1: menciono la clase para rigidbody; creo un multiplicador para el salto;
    var booleana para evitar saltos seguidos)*/
    private Rigidbody2D rb;
    public float multiplicadorSalto = 1f;
    private bool puedoSaltar = true;

    //Animación; para distinguir cuando camina y cuando no --- activar Idle (1: menciono y denomino al controlador de anim)
    private Animator animatorController;



    void Start(){

        //Movimiento (2: aclaro que la posición inicial se va a modificar/ACTUALIZADO)
        respawn = GameObject.Find("respawn");
        transform.position = respawn.transform.position;


        /*en caso de querer que se gire, rote, etc. también se puede hacer así,
        mediante "this.GetComponent<'VentanaDePropiedadesDeseada'>().'Propiedad' = 'ElValorDeseado'":
            ---this.GetComponent<SpriteRenderer>().flipX = true;*/
         

        //Cuerpo sólido (2: vincular la clase a la propiedad del personaje para que tenga acceso a ella)
        rb = GetComponent<Rigidbody2D>();

        //Animación (2: acceder a las propiedades en Unity)
        animatorController = this.GetComponent<Animator>();

    }





    void Update(){

        if(GameManager.estoyMuerto) return;
        
        /*Movimiento (3: FORMA MÁS EXTENSA de conseguir movimiento):

            ·Establecimiento de variable de posición actual:
                ---float posActual =  this.GetComponent<Transform>().position.x;

            ·"this.GetComponent<Transform>().position" es igual que "transform.position"; FORMA MÁS SENCILLA:
                ---transform.position = new Vector3 (posActual+0.01f, -0.5f, 0); 

            ·También puede rotar. "Debug.Log" es para ver el valor durante los cambios. "transform.Rotate('x','y','z')":
                ---Debug.Log(transform.rotation);
                ---transform.Rotate(0, 0, velocidad);*/



        /*Cambio de color (2: para poder modificar el color, accediendo a las propiedades)
        this.GetComponent<SpriteRenderer>().color = miColor;*/


        /*Movimiento (4: enlace del movimiento al input; "transform.position" y "transform.Translate"
        son casi iguales; la última registra de por sí la posición actual=*/
        if(Input.GetKey(KeyCode.A)){ //Ir a la izquierda
            transform.Translate(velocidad*-1, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = true;
            animatorController.SetBool("activaStay", true);
        } else if(Input.GetKey(KeyCode.D)){ //Ir a la derecha
            transform.Translate(velocidad, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = false;
            animatorController.SetBool("activaStay", true);
        } else {
            animatorController.SetBool("activaStay", false);
        }



        /*Cuerpo sólido (3: coherencia de movimiento según el plano [terreno])
            ---rb.velocity = new Vector2(multiplicadorSalto, rb.velocity.y);
        en el vídeo usa movTeclas, nosotros no tenemos esa función*/

        /*Cuerpo sólido (4: para que el personaje colisione con objetos + no pueda volver a saltar hasta que toque el SUELO;
        "Raycast('origen', 'dirección', 'magnitud, longitud')")*/
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.blue);

        if (hit){
            puedoSaltar = true;
            //Debug.Log(hit.collider.name);
        }else { 
            puedoSaltar = false;
        }

        /*Cuerpo sólido (5: cuando pulsamos " ", le hace efecto una fuerza;
        "AddForce('dirección' (vector de 2 valores solo), 'TipoDeFuerza' (impulso en nuestro caso))")*/
        if(Input.GetKey(KeyCode.Space) && puedoSaltar){ //Saltar

            rb.AddForce(new Vector2(0, multiplicadorSalto), ForceMode2D.Impulse);
            puedoSaltar = false;

        }




        //Comprobar si me he salido de la pantalla (por debajo)
        if(transform.position.y <= -6){
            Respawnear();
        }


        // 0 vidas
        if(GameManager.vidas <= 0){
            GameManager.estoyMuerto = true;
        }

        float miDeltaTime = Time.deltaTime;
        
    }



    public void Respawnear(){
        transform.position = respawn.transform.position;

        Debug.Log("Vidas: "+GameManager.vidas);
        GameManager.vidas = GameManager.vidas -1;
        Debug.Log("Vidas: "+GameManager.vidas);
    }



    /*GUI (para ver el texto en la consola; es solo para probar el ratón)
    void OnGUI(){
        if (Event.current.isMouse && Event.current.button == 0){
            Debug.Log("awa");
        }
    }*/


}
