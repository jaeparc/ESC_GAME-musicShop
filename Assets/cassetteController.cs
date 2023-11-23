using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interactable.Toolkit;

public class cassetteController : MonoBehaviour
{
    public GameObject[] sockets = new GameObject[4];

    void lock(int id){
        //sockets[id].GetComponent<XRSocketInteractor>().GetOldestGetOldestInteractableSelected().transform.gameObject.GetComponent<XRGrabInteractable>().InteractionLayerMask
    }
}
