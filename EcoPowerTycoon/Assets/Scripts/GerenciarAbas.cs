using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciarAbas : MonoBehaviour
{
    public GameObject painelDeCentrosDePesquisa;
    public GameObject painelDeMeiosdeProducao;
    public GameObject painelDeMelhorias;

    public void AtivarPainelDeCentrosDePesquisa()
    {
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = 0.0f;
        painelDeMelhorias.GetComponent<CanvasGroup>().alpha = 0.0f;

        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().interactable = false;
        painelDeMelhorias.GetComponent<CanvasGroup>().interactable = false;

        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = 1.0f;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = true;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().transform.SetAsLastSibling();

    }

    public void AtivarPainelDeMeiosDeProducao()
    {

        painelDeMelhorias.GetComponent<CanvasGroup>().alpha = 0.0f;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = 0.0f;

        painelDeMelhorias.GetComponent<CanvasGroup>().interactable = false;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = false;

        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = 1.0f;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().interactable = true;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().transform.SetAsLastSibling();
    }

    public void AtivarPainelDeMelhorias()
    {
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = 0.0f;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = 0.0f;

        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = false;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().interactable= false;

        painelDeMelhorias.GetComponent<CanvasGroup>().alpha= 1.0f;
        painelDeMelhorias.GetComponent<CanvasGroup>().interactable = true;
        painelDeMelhorias.GetComponent<CanvasGroup>().transform.SetAsLastSibling();
    }
}
