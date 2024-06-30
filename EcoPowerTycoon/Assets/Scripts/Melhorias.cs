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

    public Usina botaoEnergiaSolar;

    public Button botaoDaMelhoria;

    public GameObject confirmacaoDeCompra;

    private AudioSource aud;

    public AudioClip somErroAoComprarMelhoria;
    void Start()
    {
        aud = GetComponent<AudioSource>();
        textoValorDaMelhoria.text = precoDaMelhoria.ToString();
    }

    public void MelhorarEnergiaSolar()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            // Fazendo a melhoria

            botaoEnergiaSolar.producaoPorSegundo = botaoEnergiaSolar.producaoPorSegundo * 2;
            botaoEnergiaSolar.AtualizarProducaoPorSegundo();

            // Atualizando a interface

            melhoriasCompradas += 1;
            textoMelhoriasCompradas.text = melhoriasCompradas + " / 10";
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
