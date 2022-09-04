using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovItems : MonoBehaviour
{
   
    Vector3 rotacion = new Vector3(15,30, 45);
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(rotacion * Time.deltaTime);
    }
}
