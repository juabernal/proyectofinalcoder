using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textoEnergia;
    public float energiaActual;
    public float energiaMax;

    public Image vidaVerde;

    public GameObject gameOverPanel;

    //bajar todo si pierdo
    public GameObject sonidoJuego;
    public GameObject tiempoJuego;
    public GameObject abejas;
    public GameObject contadorDeItems;
    public GameObject panelVida;

    public GameObject panelWin;

    void actualizarDisplay()
    {
        textoEnergia.text = energiaActual.ToString();
        
        float valorDeseado = energiaActual / energiaMax;
        if (valorDeseado == 0) vidaVerde.fillAmount = 0;
        vidaVerde.fillAmount = Mathf.Lerp(vidaVerde.fillAmount, valorDeseado, 0.05f);
        
    }

    private void Update()
    {
        actualizarDisplay();
        
       
        if (energiaActual <= 0)
        {
           
            gameOverPanel.gameObject.SetActive(true);
            energiaActual = 0;
            sonidoJuego.SetActive(false);
            tiempoJuego.SetActive(false);
            contadorDeItems.SetActive(false);
            abejas.SetActive(false);
            panelVida.SetActive(false);
            Invoke("MenuPrincipal", 8f);
           
        }


    }

    void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
