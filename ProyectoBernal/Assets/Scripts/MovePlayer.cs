using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 10f;

    private float movHorizontal;
    private float movVertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        movVertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(movHorizontal, 0, movVertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
