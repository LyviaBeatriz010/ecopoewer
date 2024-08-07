using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GerenciarAbas : MonoBehaviour
{
    public GameObject painelDeCentrosDePesquisa;
    public GameObject painelDeMeiosdeProducao;
    public GameObject painelDeMelhorias;

    public GameObject botaoQueAtivaPainelCentrosDePesquisa;
    public GameObject botaoQueAtivaPainelMeiosDeProducao;
    public GameObject botaoQueAtivaPainelMelhorias;

    public TextMeshProUGUI textoBotaoI;
    public TextMeshProUGUI textoBotaoII;
    public TextMeshProUGUI textoBotaoIII;

   

    public void AtivarPainelDeCentrosDePesquisa()
    {
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = 0.0f;
        painelDeMelhorias.GetComponent<CanvasGroup>().alpha = 0.0f;

        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().interactable = false;
        painelDeMelhorias.GetComponent<CanvasGroup>().interactable = false;

        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = 1.0f;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = true;
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().transform.SetAsLastSibling();

        botaoQueAtivaPainelCentrosDePesquisa.transform.SetAsLastSibling();

        botaoQueAtivaPainelCentrosDePesquisa.gameObject.GetComponent<Image>().color = new Color(2f / 255f, 61f / 255f, 97f / 255);
        botaoQueAtivaPainelCentrosDePesquisa.GetComponentInChildren<TMP_Text>().color = new Color(150f / 255f, 150f / 255f, 150f / 255); 
        
        botaoQueAtivaPainelMeiosDeProducao.gameObject.GetComponent<Image>().color =  new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelMeiosDeProducao.GetComponentInChildren<TMP_Text>().color = Color.black;
        
        botaoQueAtivaPainelMelhorias.gameObject.GetComponent<Image>().color =  new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelMelhorias.GetComponentInChildren<TMP_Text>().color = Color.black;
       



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

        botaoQueAtivaPainelMeiosDeProducao.transform.SetAsLastSibling();

        botaoQueAtivaPainelMeiosDeProducao.gameObject.GetComponent<Image>().color = new Color(2f / 255f, 61f / 255f, 97f / 255);
        botaoQueAtivaPainelMeiosDeProducao.GetComponentInChildren<TMP_Text>().color = new Color(150f / 255f, 150f / 255f, 150f / 255); 
        
        botaoQueAtivaPainelCentrosDePesquisa.gameObject.GetComponent<Image>().color = new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelCentrosDePesquisa.GetComponentInChildren<TMP_Text>().color = Color.black;
        
        botaoQueAtivaPainelMelhorias.gameObject.GetComponent<Image>().color =  new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelMelhorias.GetComponentInChildren<TMP_Text>().color = Color.black;
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

        botaoQueAtivaPainelMelhorias.transform.SetAsLastSibling();
       
        botaoQueAtivaPainelMelhorias.gameObject.GetComponent<Image>().color = new Color(2f / 255f, 61f / 255f, 97f / 255);
        botaoQueAtivaPainelMelhorias.GetComponentInChildren<TMP_Text>().color = new Color(150f / 255f, 150f / 255f, 150f / 255);
        
        botaoQueAtivaPainelCentrosDePesquisa.gameObject.GetComponent<Image>().color =  new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelCentrosDePesquisa.GetComponentInChildren<TMP_Text>().color = Color.black;
        
        botaoQueAtivaPainelMeiosDeProducao.gameObject.GetComponent<Image>().color = new Color(246f / 255f, 249f / 255f, 145f / 255);
        botaoQueAtivaPainelMeiosDeProducao.GetComponentInChildren<TMP_Text>().color = Color.black;

    }
}
