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

            botaoEnergiaSolar.producaoPorSegundo++;
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
        }
    }


    // Melhoria 2
    public void MelhorarCentroDePesquisasUm()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroBasicoDePesquisaUm.pontosPorSegundo++;
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
        }
    }

    // Melhoria 3
    public void MelhorarEnergiaEolica()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaEolica.producaoPorSegundo++;
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
        }
    }

    // Melhoria 4
    public void MelhorarCentroDePesquisasDois()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroBasicoDePesquisaDois.pontosPorSegundo++;
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
        }
    }

    // Melhoria 5
    public void MelhorarEnergiaHidroeletrica()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaHidroeletrica.producaoPorSegundo++;
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
        }
    }

    // Melhoria 6
    public void MelhorarCentroPesquisasNivelMedio()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoCentroPesquisasNivelMedio.pontosPorSegundo++;
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
        }
    }

    // Melhoria 7
    public void MelhorarPontosPorCliquesUm()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            GameManager.instance.valorPorClique++;

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);
        }
    }

    // Melhoria 8
    public void MelhorarPontosPorCliquesDois()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            GameManager.instance.valorPorClique += 2;

            // Atualizando a interface

            melhoriasCompradas += 1;
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);
        }
    }
}
