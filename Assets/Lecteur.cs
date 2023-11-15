using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecteur : MonoBehaviour
{
    public GameObject speaker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSong(){
        speaker.GetComponent<AudioSource>().clip = transform.GetChild(0).GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().GetComponent<vinyle>().music;
    }
}
