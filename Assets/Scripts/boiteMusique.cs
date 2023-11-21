using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class boiteMusique : MonoBehaviour
{
    public GameObject supportPrefab, supportInstance;
    public AudioClip music;
    public Transform supportAppearancePosition;
    public XRSocketInteractor socket;
    public Texture fiche;

    public void Selected(){
        if(supportInstance==null){
            supportInstance = Instantiate(supportPrefab,supportAppearancePosition);
            supportInstance.GetComponent<supportMusique>().boiteMusique = gameObject;
            supportInstance.GetComponent<supportMusique>().music = music;
        }
    }

    public void Deselected(){
        if(!supportInstance.GetComponent<supportMusique>().select)
            Destroy(supportInstance);
    }

    public void destroySupportInstance(){
        if(socket.GetOldestInteractableSelected().transform.gameObject == supportInstance)
            Destroy(supportInstance);
    }
}
