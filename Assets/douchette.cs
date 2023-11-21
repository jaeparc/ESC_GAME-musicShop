using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class douchette : MonoBehaviour
{
    public GameObject rayonScan;

    public void plug(){
        rayonScan.SetActive(true);
    }

    public void unplug(){
        rayonScan.SetActive(false);
    }
}
