using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBotiquin : MonoBehaviour
{
    Vector3 rotacion = new Vector3(30, 0, 0);
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(rotacion * Time.deltaTime);
    }
}
