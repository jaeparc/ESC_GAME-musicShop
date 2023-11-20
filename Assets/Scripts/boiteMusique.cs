using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boiteMusique : MonoBehaviour
{
    //COUCOU
    public GameObject supportPrefab, supportInstance;
    public Transform supportAppearancePosition;

    public void Selected(){
        if(supportInstance==null){
            supportInstance = Instantiate(supportPrefab,supportAppearancePosition);
            supportInstance.GetComponent<supportMusique>().boiteMusique = gameObject;
        }
    }

    public void Deselected(){
        if(!supportInstance.GetComponent<supportMusique>().select)
            Destroy(supportInstance);
    }
}
