using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public void OnClickPlay()
    {
        Application.Quit();
        Debug.Log("salió del juego");

    }
}
