using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartel_int : MonoBehaviour
{

 private GameObject panelCartel;
 private Animator cartelController;

    void Start()
    {
        panelCartel = GameObject.Find("Cartel_int");
        panelCartel.SetActive(false);

        cartelController = panelCartel.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) {

                cartelController.SetBool("CartelGrande",false);
                //panelCartel.SetActive(false);

        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            
            panelCartel.SetActive(true);
            cartelController.SetBool("CartelGrande", true);

        }
    }
}
