using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Indicaciones");

    }
}
