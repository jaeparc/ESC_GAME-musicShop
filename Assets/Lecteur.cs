using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lecteur : MonoBehaviour
{

    public GameObject speaker, contenuInserted, slot;
    public bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speaker.GetComponent<AudioSource>().isPlaying);
    }

    public void insertMusic(){
        contenuInserted = slot.GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject;
        speaker.GetComponent<AudioSource>().clip = contenuInserted.GetComponent<vinyle>().music;
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
    }
}
