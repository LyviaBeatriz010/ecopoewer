using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public EcoEnum.Meta metaBaseAtual;
    
    private int anoAtual;
    public int valorPorClique = 1;
    public int energiaAtual = 0;
    public int pontosPesquisaAtual = 0;
    public int metaAtual;
    public int dinheiroAtual;
    
    public TextMeshProUGUI textoEnergiaAtual;
    public TextMeshProUGUI textoPontosPesquisaAtual;
    public TextMeshProUGUI textoTimer;
    public TextMeshProUGUI textoAno;
    public TextMeshProUGUI textoMeta;
    public TextMeshProUGUI textoDinheiro;

    public GameObject painelDaVitoria;
    public GameObject painelDaDerrota;

    public float tempoTotal;
    public float tempoAtual;
  
    private TimeSpan cronometro;
    
    public bool acabou = false;
    
    //public string[] usinas;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        ChecarFase();
        tempoAtual = tempoTotal;
        metaAtual = (int) metaBaseAtual + PlayerPrefs.GetInt("DEFICITMETA",0);
        textoMeta.text = metaAtual.ToString();
    }

    public void ChecarFase()
    {
        // Esse metodo serve para checar em qual fase (ano atual) o jogador está.
        
        anoAtual = PlayerPrefs.GetInt("ANOATUAL", 2026);

        textoAno.text = anoAtual.ToString();

        switch (anoAtual)
        {
            case 2026:
                metaBaseAtual = EcoEnum.Meta.Ano2026;
                break;
            case 2027:
                metaBaseAtual = EcoEnum.Meta.Ano2027;
                break;
            case 2028:
                metaBaseAtual = EcoEnum.Meta.Ano2028;
                break;
            case 2029:
                metaBaseAtual = EcoEnum.Meta.Ano2029;
                break;
            case 2030:
                metaBaseAtual = EcoEnum.Meta.Ano2030;
                break;
            default:
                break;
        }
    }
    
    void Update()
    {
        // Conferindo se o tempo da fase não acabou
        
        if (!acabou)
        {
            FaseRodando();
        }
        
        // Se o tempo acabar e o jogador não tiver atingido a meta acontece isso (tela de derrota):
        
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Passarfase();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void FaseRodando()
    {
        // Faz o cronometro funcionar
        
        if (tempoAtual > 0)
        {
            tempoAtual -= Time.deltaTime;
        }
        
        // Indentifica se o cronometro chegou a zero
        // Indentifica quanto vai ser somado a meta do ano seguinte
        
        else
        {
            tempoAtual = 0;
            
            if (energiaAtual < metaAtual)
            {
                PlayerPrefs.SetInt("DEFICITMETA",metaAtual - energiaAtual);
                painelDaDerrota.SetActive(true);
                acabou = true;
            }
        }
        
        // Definindo o tempo do cronometro:
        
        cronometro = TimeSpan.FromSeconds(tempoAtual);
        textoTimer.text = cronometro.ToString(@"mm\:ss");
       
        // Confere se o jogador concluiu a meta e chama a vitoria
        
        if (tempoAtual > 0 && energiaAtual >= metaAtual)
        {
            painelDaVitoria.SetActive(true);
            acabou = true;
        }
    }

    public void Cliques()
    {
        // Faz os cliques no painel piezoeletrico adicionarem pontos a energia atual
        
        energiaAtual += valorPorClique;
        textoEnergiaAtual.text = energiaAtual.ToString();
    }

    public void Passarfase()
    {
        acabou = true;
        painelDaVitoria.SetActive(false);
        painelDaDerrota.SetActive(false);
        PlayerPrefs.SetInt("ANOATUAL", anoAtual + 1);
    }

    public void VenderEnergia()
    {
        dinheiroAtual += energiaAtual;
        energiaAtual = 0;
        
        textoEnergiaAtual.text = energiaAtual.ToString();
        textoDinheiro.text = dinheiroAtual.ToString();
    }

    public bool FazerCompra(int preco)
    {
        bool sucesso = false;
        
        if (dinheiroAtual >= preco)
        {
            sucesso = true;
            dinheiroAtual -= preco;
            //atualiza interface
            textoDinheiro.text = dinheiroAtual.ToString();
        }

        return sucesso;
    }
    public bool GastarPontosPesquisa(int precoEmPontos)
    {
        bool sucesso = false;

        if (pontosPesquisaAtual >= precoEmPontos)
        {
            sucesso = true;
            pontosPesquisaAtual -= precoEmPontos;
            //atualiza interface
            textoPontosPesquisaAtual.text = pontosPesquisaAtual.ToString();
        }

        return sucesso;
    }
}
