using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorMapa : MonoBehaviour
{
    // 9 Usinas
    
    public Usina usina1;
    public Usina usina2;
    public Usina usina3;
    public Usina usina4;
    public Usina usina5;
    public Usina usina6;
    public Usina usina7;
    public Usina usina8;
    public Usina usina9;
    public Usina usina10;
    
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

    public GameObject usina1imagem;
    public GameObject usina2imagem;
    public GameObject usina3imagem;
    public GameObject usina4imagem;
    public GameObject usina5imagem;
    public GameObject usina6imagem;
    public GameObject usina7imagem;
    public GameObject usina8imagem;
    public GameObject usina9imagem;
    public GameObject usina10imagem;
    
    // Energia solar

    private void Update()
    {
        AtivarCentroPesquisa1();
        AtivarCentroPesquisa2();
        AtivarCentroPesquisa3();
        AtivarCentroPesquisa4();
        AtivarCentroPesquisa5();
        
        AtivarUsina1();
        AtivarUsina2();
        AtivarUsina3();
        AtivarUsina4();
        AtivarUsina5();
        AtivarUsina6();
        AtivarUsina7();
        AtivarUsina8();
        AtivarUsina9();
        AtivarUsina10();
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
    
    void AtivarUsina1()
    {
        if (usina1.quantidadeUsinas == 1)
        {
            usina1imagem.SetActive(true);
        }
    }
    void AtivarUsina2()
    {
        if (usina2.quantidadeUsinas == 1)
        {
            usina2imagem.SetActive(true);
        }
    }
    void AtivarUsina3()
    {
        if (usina3.quantidadeUsinas == 1)
        {
            usina3imagem.SetActive(true);
        }
    }
    void AtivarUsina4()
    {
        if (usina4.quantidadeUsinas == 1)
        {
            usina4imagem.SetActive(true);
        }
    }
    void AtivarUsina5()
    {
        if (usina5.quantidadeUsinas == 1)
        {
            usina5imagem.SetActive(true);
        }
    }
    void AtivarUsina6()
    {
        if (usina6.quantidadeUsinas == 1)
        {
            usina6imagem.SetActive(true);
        }
    }
    void AtivarUsina7()
    {
        if (usina7.quantidadeUsinas == 1)
        {
            usina7imagem.SetActive(true);
        }
    }
    void AtivarUsina8()
    {
        if (usina8.quantidadeUsinas == 1)
        {
            usina8imagem.SetActive(true);
        }
    }
    void AtivarUsina9()
    {
        if (usina9.quantidadeUsinas == 1)
        {
            usina9imagem.SetActive(true);
        }
    }
    void AtivarUsina10()
    {
        if (usina10.quantidadeUsinas == 1)
        {
            usina10imagem.SetActive(true);
        }
    }
}
