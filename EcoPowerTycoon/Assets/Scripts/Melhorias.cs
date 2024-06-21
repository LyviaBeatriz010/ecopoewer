using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Melhorias : MonoBehaviour
{
    public int precoDaMelhoria;

    public TextMeshProUGUI textoValorDaMelhoria;

    public Usina botaoEnergiaSolar;

    public Button botaoDaMelhoria;

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
            botaoDaMelhoria.interactable = false; 
        }
    }
}
