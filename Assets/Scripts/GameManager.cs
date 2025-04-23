using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
//Para las stats
public static int vidas = 3;
public static int score = 0;
public static int enemigosMatados = 0;

//Para las muertes
public static bool estoyMuerto = false;

//Para los textos de las stats
private GameObject vidasText;
private GameObject puntosText;
private GameObject enemiesText;
private GameObject avisosObj;
private GameObject avisosText;

//Solo en este caso he puesto el audio desde el Game Manager
private GameObject sonidoMuerteFantasma;
AudioSource fantasmaAudioManager;




    void Start()
    {
        //Debug.Log("Vidas: "+vidas);
        //Debug.Log("Puntos: "+score);
        //Debug.Log("Enemigos matados: "+enemigosMatados);

        vidasText = GameObject.Find("TextoVidas");
        puntosText = GameObject.Find("TextoPuntos");
        enemiesText = GameObject.Find("TextoEnemigos");
        avisosObj = GameObject.Find("TextoAvisos");
        avisosText = GameObject.Find("Avisos");

        avisosObj.SetActive(false);

        
        sonidoMuerteFantasma = GameObject.Find("SonidoMuerteFantasma");
        fantasmaAudioManager = sonidoMuerteFantasma.GetComponent<AudioSource>();

    }

    void Update() 
    {
        
        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
        puntosText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        enemiesText.GetComponent<TextMeshProUGUI>().text = enemigosMatados.ToString();
    
    }



    public void ResetPuntuacion() {
        vidas = 3;
        score = 0;
        enemigosMatados = 0;
    }
    /*Cuando las stats se resetean al volver a jugar tras ganar, como Unity no encontraba el GameManager al no estar en la escena
    "Victoria", fue necesario incluirlo mediante un prefab, por eso pueden salir errores de que no encuentra los textos que
    aparecen durante la partida, pero no hay ningún error como tal.
    
    No hay opción a ponerlo antes porque sino cuando sale la puntuación pondría el score base "30" (3 vidas y 0 puntos y muertes)*/




    //PARA LOS AVISOS DURANTE LA PARTIDA
    public void AvisoFantasma() {
        avisosObj.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has matado a un enemigo!"; 
        /*Solo en este caso he puesto en el GameManager el audio de la muerte del fantasma;
        el resto de sonidos los hemos practicado de formas distintas. Para el proyecto final trataré
        de ponerlos todos de la misma manera*/
        fantasmaAudioManager.PlayOneShot(AudioManager.Instance.sonidoMatar);  
    }

    public void AvisoSalvar() {
        avisosObj.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido una vida!";   
    }

    public void AvisoPunto() {
        avisosObj.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido un punto!";   
    }
    public void AvisoPuntos() {
        avisosObj.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido varios puntos!";   
    }

    public void AvisoMuerte() {
        avisosObj.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has perdido una vida!";   
    }

    public void OcultarAvisos() {
        avisosObj.SetActive(false);
    }

}
