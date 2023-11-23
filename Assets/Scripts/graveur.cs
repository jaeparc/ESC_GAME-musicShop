using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class graveur : MonoBehaviour
{
    public GameObject[] lecteurAssocies = new GameObject[1];
    public GameObject voyantCassette;
    public AudioClip music;
    public GameObject keyObject, socket;
    public Transform keyObjectAppearancePos;
    public bool isOk = true, done = false;

    void Update(){
        testLecteur();
    }

    void testLecteur(){
        isOk = true;
        for(int i = 0; i < lecteurAssocies.Length; i++){
            if(!lecteurAssocies[i].GetComponent<enigme3>().matchingAudios)
                isOk = false;
        }
    }

    public void cassetteInserted(){
        if(socket.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject.GetComponent<supportMusique>().music == null){
            voyantCassette.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        }else{
            voyantCassette.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        }
    }

    public void finishEnigme(){
        if(isOk && !done && socket.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected() != null && socket.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject.GetComponent<supportMusique>().music == null){
            Instantiate(keyObject,keyObjectAppearancePos);
            socket.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject.GetComponent<supportMusique>().music = music;
            done = true;
        }
    }
}
