using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
   public void CarregarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene(0);
    }
}
