using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocity = 100f;
    public float veldiagonal = 45f;
    
    
    
    void Start()
    {
     
    }


    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0, Vertical);
        transform.Translate(direction);

    }

    


}
