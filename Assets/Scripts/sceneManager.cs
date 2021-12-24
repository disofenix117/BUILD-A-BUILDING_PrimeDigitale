using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour
{
    public void cargarScene(string scene)
    {
        SceneManager.LoadScene(scene);
        
    }

    public void Pausa()
    {
        Time.timeScale=0f;

    }
    public void Reanudar()
    {
        Time.timeScale=1f;
    }

}