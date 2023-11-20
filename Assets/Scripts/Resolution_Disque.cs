using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution_Disque : MonoBehaviour
{
    int i;
    public List<bool> Liste_Resolution = new List<bool>{false,false,false,false,false,false};
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Check_Resolution()
    {
        for (i = 0; i < 5; i++ )
        {
            if(Liste_Resolution[i] == false)
            {
                Debug.Log("fals");
                break;
            } 

            else{
                Debug.Log("tru");
                break;
            }

        }
    }
}
