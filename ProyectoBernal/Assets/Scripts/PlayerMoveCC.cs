using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMoveCC : MonoBehaviour
{
    //Movimiento Jugador
    public CharacterController controller;
    public float speed = 100f;
    private float movX;
    private float movZ;

    [SerializeField]
    [Range(-300f,-800f)]
    public float gravity = -9.81f;
    [SerializeField]
    [Range(1f, 300f)]
    public float fuerzaSalto = 3;

    public Transform chequeoPiso;
    public float distanciaPiso = 0.3f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    //animacion
    [SerializeField] Animator playerAnim;
    
    void Start()
    {
        //movimiento
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(chequeoPiso.position, distanciaPiso, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2;

        }
        
        
       

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * movX + transform.forward * movZ;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
                {
            velocity.y = Mathf.Sqrt(fuerzaSalto * -2 * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        playerAnim.SetFloat("velX", movX);
        playerAnim.SetFloat("velY", movZ);

        MainMenu();
    }

    public void MainMenu()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Menu Principal");
        }
    }
    
}

