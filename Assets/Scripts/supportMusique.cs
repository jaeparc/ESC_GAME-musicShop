using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.XR.Interaction.Toolkit;

public class supportMusique : MonoBehaviour
{
    public bool select;
    public AudioClip music;
    public GameObject boiteMusique;

    public void Selected(){
        select = true;
        transform.SetParent(null);
    }

    public void Deselected(){
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
