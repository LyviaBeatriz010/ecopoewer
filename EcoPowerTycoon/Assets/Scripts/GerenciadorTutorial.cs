using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorTutorial : MonoBehaviour
{
    // Objetos tutorial parte 2

    public GameObject painelRecursos;
    public GameObject botaoDistribuir;
    public GameObject painelMetas;

    public GameObject objetosParte3;
    public GameObject objetosAntigos;

    public int quantidadeParaParte3;

    // GameManager

    public GameManager gameManager;

    private void Update()
    {
        IniciarParte3();
    }

    public void IniciarParte3()
    {
        if (gameManager.energiaAtual == quantidadeParaParte3)
        {
            objetosAntigos.SetActive(false);

            painelRecursos.SetActive(true);
            botaoDistribuir.SetActive(true);
            painelMetas.SetActive(true);
            objetosParte3.SetActive(true);  
        }
    }
}
