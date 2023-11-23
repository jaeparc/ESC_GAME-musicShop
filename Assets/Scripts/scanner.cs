using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scanner : MonoBehaviour
{
    public GameObject ecran;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("PochetteVinyle") && other.GetComponent<boiteMusique>().fiche != null){
            ecran.GetComponent<RawImage>().texture = other.GetComponent<boiteMusique>().fiche;
        }
    }
}
