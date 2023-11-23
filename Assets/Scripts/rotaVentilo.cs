using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaVentilo : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rota();
    }

    void rota(){
        float realSpeed = speed*Time.deltaTime;
        transform.Rotate(0,realSpeed,0);
    }
}
