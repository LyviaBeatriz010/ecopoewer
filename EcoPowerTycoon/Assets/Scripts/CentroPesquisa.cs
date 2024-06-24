using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.SpriteAssetUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CentroPesquisa : MonoBehaviour
{
  
   public EcoEnum.TipoCentro tipodeCentro;
   public int precoDoCentro;
   public int pontosPorSegundo;
   public int quantidadeCentros;
   public int valorParaDesbloquearCentro;

   public TextMeshProUGUI textoQuantidadeDeCentros;
   public TextMeshProUGUI textoPrecoCentro;
   public TextMeshProUGUI textoPontosPorSegundo;
   public TextMeshProUGUI textoPrecoDeDesbloqueioCentroPesquisa;

   public Button botaoDoCentroDePesquisa;
   public GameObject botaoParaDesbloquearCentroPesquisa;

   public bool produzindoPontos = false;
   void Start()
   {
      textoPrecoCentro.text = precoDoCentro.ToString();
      textoPontosPorSegundo.text = pontosPorSegundo + " GW/s";
      textoPrecoDeDesbloqueioCentroPesquisa.text = valorParaDesbloquearCentro.ToString();
   }

   public void ComprarCentro()
   {
      if (GameManager.instance.FazerCompra(precoDoCentro))
      {
         //compra deu certo
         quantidadeCentros += 1;
         textoQuantidadeDeCentros.text = quantidadeCentros.ToString();
         precoDoCentro = precoDoCentro * 2;
         textoPrecoCentro.text = precoDoCentro.ToString();
         //chamada de audio de sucesso
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
      }
      
      //verificar se foi o primeiro
      //chamar a corotina aqui
      
      if (quantidadeCentros == 1)
      {
         produzindoPontos = true;
         
         StartCoroutine(ProduzindoPontos());
      }
   }

   IEnumerator ProduzindoPontos()
   {
      while (produzindoPontos)
      {
         GameManager.instance.pontosPesquisaAtual += (pontosPorSegundo * quantidadeCentros);
         GameManager.instance.textoPontosPesquisaAtual.text = GameManager.instance.pontosPesquisaAtual.ToString();
      
         yield return new WaitForSeconds(1.0f);  
      }

      StopCoroutine(ProduzindoPontos());
   }    

   public void DesbloquearCentro()
   {
      if(GameManager.instance.FazerCompra(valorParaDesbloquearCentro))
      {
         botaoDoCentroDePesquisa.interactable = true;
         botaoParaDesbloquearCentroPesquisa.SetActive(false);
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
      }
   }
}
