using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.SpriteAssetUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CentroPesquisa : MonoBehaviour
{
   public string tituloBotao;
   
   public EcoEnum.TipoCentro tipodeCentro;
   public int precoDoCentro;
   public int pontosPorSegundo;
   public int quantidadeCentros;

   public TextMeshProUGUI textoQuantidadeDeCentros;
   public TextMeshProUGUI textoTipoCentro;
   public TextMeshProUGUI textoPrecoCentro;
   public TextMeshProUGUI textoPontosPorSegundo;

   public bool produzindoPontos = false;
   void Start()
   {
      textoTipoCentro.text = tituloBotao;
      textoPrecoCentro.text = precoDoCentro.ToString();
      textoPontosPorSegundo.text = pontosPorSegundo + " GW/s";
   }

   public void ComprarCentro()
   {
      if (GameManager.instance.FazerCompra(precoDoCentro))
      {
         //compra deu certo
         quantidadeCentros += 1;
         textoQuantidadeDeCentros.text = quantidadeCentros.ToString();
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
}
