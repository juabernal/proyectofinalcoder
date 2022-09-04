using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnClickPlay()
    {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Menu Principal");
       
    }
}
