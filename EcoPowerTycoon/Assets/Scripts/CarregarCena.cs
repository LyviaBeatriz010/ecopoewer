using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
   public void CarregarJogo()
    {
        SceneManager.LoadScene(2);
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseCarregandoMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }

    public void CarregarTutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void FecharJogo()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        
        Application.Quit();
        
    }

    public void VoltarParaOTempoNormal()
    {
        Time.timeScale = 1;
    }
}
