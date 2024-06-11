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

    public float tempoTotal = 70;
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
            
        Debug.Log("ano atual: "+ (PlayerPrefs.GetInt("ANOATUAL",2026))); 
        Debug.Log("deficit do ano anterior: "+PlayerPrefs.GetInt("DEFICITMETA",0)); 
    }

    public void ChecarFase()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        if (!acabou)
        {
            FaseRodando();
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
    }

    public void FaseRodando()
    {
        if (tempoAtual > 0)
        {
            tempoAtual -= Time.deltaTime;
        }
        else
        {
            tempoAtual = 0;
            
            if (energiaAtual < metaAtual)
            {
                PlayerPrefs.SetInt("DEFICITMETA",metaAtual - energiaAtual);
                Debug.Log("GamerOver");
                Passarfase();
            }
        }
        
        
        cronometro = TimeSpan.FromSeconds(tempoAtual);
        textoTimer.text = cronometro.ToString(@"mm\:ss");

        // Cliques();
       
        // vitory
        if (tempoAtual > 0 && energiaAtual >= metaAtual)
        {
            Debug.Log("Vitory");
            Passarfase();
        }

        
    }

    public void Cliques()
    {
        energiaAtual += valorPorClique;
        textoEnergiaAtual.text = energiaAtual.ToString();
    }

    public void Passarfase()
    {
        acabou = true;
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
