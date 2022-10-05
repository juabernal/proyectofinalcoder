using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TimeGame : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;
    public GameObject gameOverPanel;
    

    public float restante;
    private bool enMarcha;

    //bajar todo si pierdo
    public GameObject sonidoJuego;
    public GameObject tiempoJuego;
    public GameObject abejas;
    public GameObject contadorDeItems;
    public GameObject panelVida;
    
    

    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
        
    }
   



    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;

            if (restante < 1)
            {

                // matar player
                enMarcha = false;
                tiempo.gameObject.SetActive(false);
             
                    gameOverPanel.gameObject.SetActive(true);
                    sonidoJuego.SetActive(false);
                    tiempoJuego.SetActive(false);
                    contadorDeItems.SetActive(false);
                    abejas.SetActive(false);
                    panelVida.SetActive(false);

                    Invoke("MenuPrincipal", 8f);
             



            }
             int tempMin = Mathf.FloorToInt(restante / 60);
             int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }

        
        
    }

    void MenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
