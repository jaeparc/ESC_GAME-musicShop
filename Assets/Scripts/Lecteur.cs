using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lecteur : MonoBehaviour
{

    public GameObject speaker, contenuInserted, slot;
    public bool isPlaying;

    public void insertMusic(){
        contenuInserted = slot.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject;
        speaker.GetComponent<AudioSource>().clip = contenuInserted.GetComponent<supportMusique>().music;
    }

    public void ejectMusic(){
        contenuInserted = null;
        speaker.GetComponent<AudioSource>().clip = null;
    }

    public void playSong(){
        if(isPlaying){
            speaker.GetComponent<AudioSource>().Play();
            isPlaying = false;
        }
        else{
            speaker.GetComponent<AudioSource>().Pause();
            isPlaying = true;
        }
        Debug.Log(speaker.GetComponent<AudioSource>().isPlaying);
    }

    public void ejectButton(){
        if(!GetComponent<Animator>().GetBool("ouverture")){
            GetComponent<Animator>().SetBool("ouverture",true);
            slot.SetActive(true);
            ejectMusic();
        } else {
            GetComponent<Animator>().SetBool("ouverture",false);
            insertMusic();
            slot.SetActive(false);
        }
    }
}
