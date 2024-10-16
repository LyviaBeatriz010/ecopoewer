using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Melhorias : MonoBehaviour
{
    public int precoDaMelhoria;
    public int melhoriasCompradas;

    public TextMeshProUGUI textoValorDaMelhoria;

    // Usinas para melhorar

    public Usina botaoEnergiaSolar;
    public Usina botaoEnergiaEolica;
    public Usina botaoEnergiaHidroeletrica;


    // Centros para melhorar

    public CentroPesquisa botaoCentroBasicoDePesquisaUm;
    public CentroPesquisa botaoCentroBasicoDePesquisaDois;
    public CentroPesquisa botaoCentroPesquisasNivelMedio;


    public Button botaoDaMelhoria;
    public GameObject confirmacaoDeCompra;
    private AudioSource aud;
    public AudioClip somErroAoComprarMelhoria;

    public Image botaoMelhoriaCor;

    private Color vermelhoCor2 = Color.red;
    private Color brancoCor2 = Color.white;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        textoValorDaMelhoria.text = precoDaMelhoria.ToString();
    }


    // Melhoria 1
    public void MelhorarEnergiaSolar()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaSolar.producaoPorSegundo += 3;
            botaoEnergiaSolar.AtualizarProducaoPorSegundo();

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false; 
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }


    // Melhoria 2
    public void MelhorarCentroDePesquisasUm()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroBasicoDePesquisaUm.pontosPorSegundo += 3;
            botaoCentroBasicoDePesquisaUm.AtualizarProducaoEmPesquisa();
           
            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 3
    public void MelhorarEnergiaEolica()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaEolica.producaoPorSegundo += 3;
            botaoEnergiaEolica.AtualizarProducaoPorSegundo();

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

           
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 4
    public void MelhorarCentroDePesquisasDois()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroBasicoDePesquisaDois.pontosPorSegundo += 3;
            botaoCentroBasicoDePesquisaDois.AtualizarProducaoEmPesquisa(); 

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 5
    public void MelhorarEnergiaHidroeletrica()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaHidroeletrica.producaoPorSegundo += 3;
            botaoEnergiaHidroeletrica.AtualizarProducaoPorSegundo();

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 6
    public void MelhorarCentroPesquisasNivelMedio()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroPesquisasNivelMedio.pontosPorSegundo += 3;
            botaoCentroPesquisasNivelMedio.AtualizarProducaoEmPesquisa();

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 7
    public void MelhorarPontosPorCliquesUm()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            GameManager.instance.valorPorClique += 20;

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }

    // Melhoria 8
    public void MelhorarPontosPorCliquesDois()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            GameManager.instance.valorPorClique += 60;

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);

            botaoMelhoriaCor.color = vermelhoCor2;
            Invoke("VoltarACorNormal", 0.3f);
        }
    }
    void VoltarACorNormal()
    {
        botaoMelhoriaCor.color = brancoCor2;
    }
}
