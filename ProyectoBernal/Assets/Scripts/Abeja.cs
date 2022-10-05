using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abeja : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    public float speed = 5f;

    // tiempo entre picaduras
    public float cooldown;
    public float ultimaPicadura;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        LookAt();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }

    }

    private void LookAt()
    {
        transform.LookAt(playerTransform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("picadura"))
        {

            if (Time.time - ultimaPicadura < cooldown)
            {

                return;
            }
            FindObjectOfType<VidaPlayer>().energiaActual--;
            ultimaPicadura = Time.time;
            Debug.Log("picadura");


        }

    }

}
