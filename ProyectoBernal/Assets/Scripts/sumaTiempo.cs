using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaTiempo : MonoBehaviour
{

    public float cooldown;
    public float ultimorecuento;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (Time.time - ultimorecuento < cooldown)
        {

            return;
        }
        FindObjectOfType<TimeGame>().restante += 30f;
        ultimorecuento = Time.time;
        
        Debug.Log("Más Tiempo!");
        
    }
}
