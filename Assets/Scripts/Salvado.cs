using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvado : MonoBehaviour
{

    GameObject Respawn;

    void Start()
    {
        Respawn = GameObject.Find("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*NO ME DIO TIEMPO A TERMINARLO
    void OnTriggerEnter2D(Collider2D col){
        Respawn.transform.position; 
    }*/
}
