using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TimeGame : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;
    public GameObject gameOverPanel;
    

    public float restante;
    private bool enMarcha;

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




              

            }
             int tempMin = Mathf.FloorToInt(restante / 60);
             int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }
}
