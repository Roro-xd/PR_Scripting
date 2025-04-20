using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
public static int vidas = 3;
public static int score = 0;
public static int enemigosMatados = 0;

public static bool estoyMuerto = false;

private GameObject vidasText;
private GameObject puntosText;
private GameObject enemiesText;
private GameObject avisosText;


private GameObject sonidoMuerteFantasma;
AudioSource fantasmaAudioManager;





    void Start()
    {
        Debug.Log("Vidas: "+vidas);
        Debug.Log("Puntos: "+score);
        Debug.Log("Enemigos matados: "+enemigosMatados);

        vidasText = GameObject.Find("TextoVidas");
        puntosText = GameObject.Find("TextoPuntos");
        enemiesText = GameObject.Find("TextoEnemigos");
        avisosText = GameObject.Find("TextoAvisos");

        avisosText.SetActive(false);

        
        sonidoMuerteFantasma = GameObject.Find("SonidoMuerteFantasma");
        fantasmaAudioManager = sonidoMuerteFantasma.GetComponent<AudioSource>();

    }

    void Update() 
    {
        
        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
        puntosText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        enemiesText.GetComponent<TextMeshProUGUI>().text = enemigosMatados.ToString();


    

    }





    public void AvisoFantasma() {
        avisosText.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has matado a un enemigo!"; 
        fantasmaAudioManager.PlayOneShot(AudioManager.Instance.sonidoMatar);  
    }

    public void AvisoSalvar() {
        avisosText.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido una vida!";   
    }


    public void AvisoPunto() {
        avisosText.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido un punto!";   
    }
    public void AvisoPuntos() {
        avisosText.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has conseguido varios puntos!";   
    }

    public void AvisoMuerte() {
        avisosText.SetActive(true);
        avisosText.GetComponent<TextMeshProUGUI>().text = "Has perdido una vida!";   
    }

    public void OcultarAvisos() {
            avisosText.SetActive(false);
    }

}
