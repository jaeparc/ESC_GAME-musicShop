using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme3 : MonoBehaviour
{
    public AudioClip targetAudio;
    public GameObject voyantLecteur,voyantGraveur;
    public bool matchingAudios;

    void Update(){
        testAudio();
    }

    void testAudio(){
        if(GetComponent<Lecteur>().contenuInserted != null && GetComponent<Lecteur>().contenuInserted.GetComponent<supportMusique>().music == targetAudio){
            matchingAudios = true;
            switchVoyant();
        } else {
            matchingAudios = false;
            switchVoyant();
        }
    }

    void switchVoyant(){
        if(matchingAudios){
            voyantLecteur.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            voyantGraveur.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }else{
            voyantLecteur.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            voyantGraveur.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
