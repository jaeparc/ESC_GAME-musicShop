using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme3 : MonoBehaviour
{
    public AudioClip targetAudio;
    public GameObject voyant;
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
        if(matchingAudios)
            voyant.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        else
            voyant.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
