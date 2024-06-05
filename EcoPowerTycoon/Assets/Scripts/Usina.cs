using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.SpriteAssetUtilities;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Usina : MonoBehaviour
{
   public string tituloBotao;
   
   public EcoEnum.TipoProducao tipodeProducao;
   public int precoDaUsina;
   public int producaoPorSegundo;
   public int quantidadeUsinas;

   public TextMeshProUGUI textoQuantidadeDeUsinas;
   public TextMeshProUGUI textoTipoProducao;
   public TextMeshProUGUI textoPrecoUsina;
   public TextMeshProUGUI textoProducaoPorSegundo;

   public Button botaoDaUsina;

   public bool produzindo = false;
   void Start()
   {
      textoTipoProducao.text = tituloBotao;
      textoPrecoUsina.text = precoDaUsina.ToString();
      textoProducaoPorSegundo.text = producaoPorSegundo + " GW/s";
   }

   public void ComprarUsina()
   {
      if (GameManager.instance.FazerCompra(precoDaUsina))
      {
         //compra deu certo
         quantidadeUsinas += 1;
         textoQuantidadeDeUsinas.text = quantidadeUsinas.ToString();
         //chamada de audio de sucesso
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
      }
      
      //verificar se foi o primeiro
      //chamar a corotina aqui
      
      if (quantidadeUsinas == 1)
      {
         produzindo = true;
         
         StartCoroutine(ProduzindoEnergia());
      }
   }

   IEnumerator ProduzindoEnergia()
   {
      while (produzindo)
      {
         GameManager.instance.energiaAtual += (producaoPorSegundo * quantidadeUsinas);
         GameManager.instance.textoEnergiaAtual.text = GameManager.instance.energiaAtual.ToString();
      
         yield return new WaitForSeconds(1.0f);  
      }

      StopCoroutine(ProduzindoEnergia());
   }

   public void DesbloquearUsina()
   {
      botaoDaUsina.interactable = true;
   }
}
