using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    
    public int miEdad = 21;
    public float miAltura = 1.60f;
    public string miNombre = "roro";
    public bool llueve = false;
    public GameObject miCubo;

    //Prueba de comentario con líneas


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("Hola, mi nombre es "+miNombre);

    }
}
