using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Trigger_Resolution : MonoBehaviour
{
    public GameObject Levier_Resolution;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        switch(other.name)
        {
            case "1":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[0] = true;
            break;

            case "2":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[1] = true;
            break;

            case "3":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[2] = true;
            break;

            case "4":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[3] = true;
            break;

            case "5":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[4] = true;
            break;

            case "6":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[5] = true;
            break;


        }
    }

    void OnTriggerExit(Collider other)
    {
        switch(other.name)
        {
            case "1":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[0] = false;
            break;

            case "2":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[1] = false;
            break;

            case "3":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[2] = false;
            break;

            case "4":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[3] = false;
            break;

            case "5":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[4] = false;
            break;

            case "6":
                Levier_Resolution.GetComponent<Resolution_Disque>().Liste_Resolution[5] = false;
            break;


        }
    }
}
