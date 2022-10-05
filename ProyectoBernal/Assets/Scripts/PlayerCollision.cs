using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public int contadorItems = 0;

    public float cooldown;
    public float ultimorecuento;

    //panel ganaste
    public GameObject winPanel;

    // contador items
    public TMPro.TextMeshProUGUI textoItems;
    public float itemActual;

    //bajar todo si gano
    public GameObject sonidoJuego;
    public GameObject tiempoJuego;
    public GameObject abejas;
    public GameObject contadorDeItems;
    public GameObject panelVida;

    // sonido de win
    public GameObject sonidoWin;

    void actualizarDisplay()
    {
        textoItems.text = itemActual.ToString();

    }
   
    // Start is called before the first frame update
    void Start()
    {
        itemActual = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        actualizarDisplay();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {

            
           
            Destroy(other.gameObject);
            

            if (Time.time - ultimorecuento < cooldown)
            {

                return;
            }
            contadorItems++;
            itemActual++;
           
            ultimorecuento = Time.time;
            Debug.Log("colisión" + contadorItems); 
        if (contadorItems == 10)
            {
                
                    winPanel.SetActive(true);
                    sonidoJuego.SetActive(false);
                    tiempoJuego.SetActive(false);
                    contadorDeItems.SetActive(false);
                    abejas.SetActive(false);
                    panelVida.SetActive(false);
                sonidoWin.SetActive(true);

                    Invoke("MenuPrincipal", 8f);
                
            }
        

        }
        else if (other.gameObject.CompareTag("clock"))
        {
           
            Destroy(other.gameObject);


        }
        else if (other.gameObject.CompareTag("medicine"))
        {
           
            Destroy(other.gameObject);
            if (Time.time - ultimorecuento < cooldown)
            {

                return;
            }
            ultimorecuento = Time.time;
            FindObjectOfType<VidaPlayer>().energiaActual++;
            FindObjectOfType<VidaPlayer>().energiaActual++;
            FindObjectOfType<VidaPlayer>().energiaActual++;

            if (FindObjectOfType<VidaPlayer>().energiaActual >=5)
            {
                FindObjectOfType<VidaPlayer>().energiaActual = 5;
            }

        }


    }

    void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
