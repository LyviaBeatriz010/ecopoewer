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
   public EcoEnum.TipoProducao tipodeProducao;
   public int precoDaUsina;
   public int precoDeDesbloqueio;
   public int producaoPorSegundo;
   public int quantidadeUsinas;

   public TextMeshProUGUI textoQuantidadeDeUsinas;
   public TextMeshProUGUI textoPrecoUsina;
   public TextMeshProUGUI textoProducaoPorSegundo;
   public TextMeshProUGUI textoPrecoDeDesbloqueio;

   private AudioSource aud;

   public AudioClip somErroNaCompra;
   public AudioClip somDeDesbloqueioUsina;

   public Button botaoDaUsina;
   public GameObject botaoParaDesbloquear;

   public bool produzindo = false;
   void Start()
   {
      aud = GetComponent<AudioSource>();
      textoPrecoUsina.text = precoDaUsina.ToString();
      textoProducaoPorSegundo.text = producaoPorSegundo + " GW/s";
      textoPrecoDeDesbloqueio.text = precoDeDesbloqueio.ToString();
   }

   public void ComprarUsina()
   {
      if (GameManager.instance.FazerCompra(precoDaUsina))
      {
         //compra deu certo
         quantidadeUsinas += 1;
         textoQuantidadeDeUsinas.text = quantidadeUsinas.ToString();
         precoDaUsina = precoDaUsina * 2;
         textoPrecoUsina.text = precoDaUsina.ToString();
         //chamada de audio de sucesso
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
         aud.PlayOneShot(somErroNaCompra,0.2f);
      }
      
      //verificar se foi o primeiro
      //chamar a corotina aqui
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
      if (GameManager.instance.GastarPontosPesquisa(precoDeDesbloqueio))
      {
         quantidadeUsinas += 1;
         textoQuantidadeDeUsinas.text = quantidadeUsinas.ToString();

         aud.PlayOneShot(somDeDesbloqueioUsina, 1f);
         botaoDaUsina.interactable = true;
         botaoParaDesbloquear.SetActive(false);
         
         if (quantidadeUsinas == 1)
         {
            produzindo = true;
         
            StartCoroutine(ProduzindoEnergia());
         }

         ControlarMensagens.instance.MensagemDeDesbloqueioUsina();
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
         aud.PlayOneShot(somErroNaCompra, 0.2f);
      }  
   }
   
   public void DesbloquearUsinaComDinheiro()
   {
      if (GameManager.instance.FazerCompra(precoDeDesbloqueio))
      {
         quantidadeUsinas += 1;
         textoQuantidadeDeUsinas.text = quantidadeUsinas.ToString();

         aud.PlayOneShot(somDeDesbloqueioUsina, 1f);
         botaoDaUsina.interactable = true;
         botaoParaDesbloquear.SetActive(false);
         
         if (quantidadeUsinas == 1)
         {
            produzindo = true;
         
            StartCoroutine(ProduzindoEnergia());
         }

         ControlarMensagens.instance.MensagemDeDesbloqueioUsina();
      }
      else
      {
         //compra deu errado
         //chamada de audio de fracasso
         aud.PlayOneShot(somErroNaCompra, 0.2f);
      }  
   }

   public void AtualizarProducaoPorSegundo()
   {
       textoProducaoPorSegundo.text = producaoPorSegundo + " GW/s";
   }
}
