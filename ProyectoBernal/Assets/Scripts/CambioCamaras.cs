using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamaras : MonoBehaviour
{
    public GameObject[] cameras;
    int indexNumber;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[2].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        { 
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(true);
        }

       
    }
}
