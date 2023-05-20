using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SalirEscena : MonoBehaviour
{
    public void LoadScene(string sceneName) {

        SceneManager.LoadScene(sceneName);
    }
}
