using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
public static int vidas = 3;
public static int score = 0;

public static bool estoyMuerto = false;


    void Start()
    {
        Debug.Log("Vidas: "+vidas);
        Debug.Log("Puntos: "+score);
    }

    // Update is called once per frame
    void Update() 
    {
        
    }
}
