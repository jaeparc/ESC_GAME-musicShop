using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class vinyle : MonoBehaviour
{
    public bool select;
    public AudioClip music;
    public GameObject pochette;

    public void Selected(){
        select = true;
        transform.SetParent(null);
    }

    public void Deselected(){
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
