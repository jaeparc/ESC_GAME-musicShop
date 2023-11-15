using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vinyle : MonoBehaviour
{
    public bool select;

    public void Selected(){
        select = true;
        transform.SetParent(null);
    }

    public void Deselected(){
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
