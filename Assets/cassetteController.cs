using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class cassetteController : MonoBehaviour
{
    public GameObject[] sockets = new GameObject[4];
    bool[] socketLocked = new bool[4];

    public void lockCoin(int id){
        sockets[id].GetComponent<XRSocketInteractor>().GetOldestInteractableSelected().transform.gameObject.GetComponent<MeshCollider>().enabled = false;
        socketLocked[id] = true;
        sockets[id].GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        testDone();
    }

    void testDone(){
        bool done = true;
        for(int i = 0; i < socketLocked.Length; i++){
            if(!socketLocked[i])
                done = false;
        }
        if(done){
            for(int j = 0; j < sockets.Length; j++)
                sockets[j].GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        }
    }
}
