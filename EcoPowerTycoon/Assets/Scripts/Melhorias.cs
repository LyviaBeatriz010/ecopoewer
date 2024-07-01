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
    public TextMeshProUGUI textoMelhoriasCompradas;

    // Usinas para melhorar

    public Usina botaoEnergiaSolar;


    // Centros para melhorar

    public CentroPesquisa botaoCentroBasicoDePesquisaUm;


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
            textoMelhoriasCompradas.text = melhoriasCompradas + " / 8";
            botaoDaMelhoria.interactable = false; 
            confirmacaoDeCompra.SetActive(true);

            // Mandando mensagem

            ControlarMensagens.instance.MensagemDesbloqueioMelhorias();
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
            textoMelhoriasCompradas.text = melhoriasCompradas + " / 8";
            botaoDaMelhoria.interactable = false;
            confirmacaoDeCompra.SetActive(true);

            // Mandando mensagem

            ControlarMensagens.instance.MensagemDesbloqueioMelhorias();
        }
        else
        {
            //Audio de compra não bem sucedida
            aud.PlayOneShot(somErroAoComprarMelhoria, 0.2f);
        }
    }
}
