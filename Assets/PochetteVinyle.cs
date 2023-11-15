using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PochetteVinyle : MonoBehaviour
{
    public GameObject vinylPrefab, vinylGO;
    public Transform vinylAppearancePosition;

    public void Selected(){
        if(vinylGO==null)
            vinylGO = Instantiate(vinylPrefab,vinylAppearancePosition);
    }

    public void Deselected(){
        if(!vinylGO.GetComponent<vinyle>().select)
            Destroy(vinylGO);
    }
}
