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

    void Start()
    {
        textoValorDaMelhoria.text = precoDaMelhoria.ToString();
    }

    public void MelhorarEnergiaSolar()
    {
        if (GameManager.instance.GastarPontosPesquisa(precoDaMelhoria))
        {
            botaoEnergiaSolar.producaoPorSegundo = botaoEnergiaSolar.producaoPorSegundo * 2;
            botaoEnergiaSolar.AtualizarProducaoPorSegundo();

            melhoriasCompradas += 1;
            textoMelhoriasCompradas.text = melhoriasCompradas + " / 10";
            botaoDaMelhoria.interactable = false; 
            confirmacaoDeCompra.SetActive(true);
        }
    }
}
