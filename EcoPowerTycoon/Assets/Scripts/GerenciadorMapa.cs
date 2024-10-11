using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorMapa : MonoBehaviour
{
    // 10 Usinas
    
    
    // 5 Centros
    
    public CentroPesquisa centroPesquisa1;
    public CentroPesquisa centroPesquisa2;
    public CentroPesquisa centroPesquisa3;
    public CentroPesquisa centroPesquisa4;
    public CentroPesquisa centroPesquisa5;

    // Todos os objetos

    public GameObject centroP1Imagem;
    public GameObject centroP2Imagem;
    public GameObject centroP3Imagem;
    public GameObject centroP4Imagem;
    public GameObject centroP5Imagem;

    private void Update()
    {
        AtivarCentroPesquisa1();
        AtivarCentroPesquisa2();
        AtivarCentroPesquisa3();
        AtivarCentroPesquisa4();
        AtivarCentroPesquisa5();
    }

    //===============================================================================
    void AtivarCentroPesquisa1()
    {
        if (centroPesquisa1.quantidadeCentros == 1)
        {
            centroP1Imagem.SetActive(true);
        }
    }
    void AtivarCentroPesquisa2()
    {
        if (centroPesquisa2.quantidadeCentros == 1)
        {
            centroP2Imagem.SetActive(true);
        }
    }
    void AtivarCentroPesquisa3()
    {
        if (centroPesquisa3.quantidadeCentros == 1)
        {
            centroP3Imagem.SetActive(true);
        }
    }
    void AtivarCentroPesquisa4()
    {
        if (centroPesquisa4.quantidadeCentros == 1)
        {
            centroP4Imagem.SetActive(true);
        }
    }
    void AtivarCentroPesquisa5()
    {
        if (centroPesquisa5.quantidadeCentros == 1)
        {
            centroP5Imagem.SetActive(true);
        }
    }
    //===============================================================================
}
