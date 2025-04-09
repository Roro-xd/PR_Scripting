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


    void Start()
    {
        Debug.Log("Vidas: "+vidas);
        Debug.Log("Puntos: "+score);
        Debug.Log("Enemigos matados: "+enemigosMatados);

        vidasText = GameObject.Find("TextoVidas");
        puntosText = GameObject.Find("TextoPuntos");
        enemiesText = GameObject.Find("TextoEnemigos");
    }

    // Update is called once per frame
    void Update() 
    {
        
        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
        puntosText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        enemiesText.GetComponent<TextMeshProUGUI>().text = enemigosMatados.ToString();

    }
}
