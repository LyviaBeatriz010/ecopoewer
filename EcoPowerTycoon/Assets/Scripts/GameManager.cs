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
    
    private int anoAtual = 2026;
    public int valorPorClique = 1;
    public int energiaAtual = 0;
    public int pontosPesquisaAtual = 0;
    public int metaAtual;
    public int dinheiroAtual;
    public int deficitMeta;
    public int distribuicaoAtual;
    
    public TextMeshProUGUI textoEnergiaAtual;
    public TextMeshProUGUI textoPontosPesquisaAtual;
    public TextMeshProUGUI textoTimer;
    public TextMeshProUGUI textoAno;
    public TextMeshProUGUI textoMeta;
    public TextMeshProUGUI textoDinheiro;

    public GameObject painelDeMetaConcluida;
    public GameObject painelDeMetaNaoConcluida;
    public GameObject painelDeVitoria;
    public GameObject painelDeDerrota;
    public GameObject painelDePausa;

    public AudioSource volumeDoLoop;
    
    public float tempoTotal;
    public float tempoAtual;
  
    private TimeSpan cronometro;

    private AudioSource aud;

    public AudioClip somCliqueNoPainelPiezo;
    public AudioClip somVenderEnergia;
    public AudioClip somGastarPontosPesquisa;
    
    public bool acabou = false;
    public bool anoFinal = false;
    public bool cumpriuMeta = false;

    public Particulas objParticulas;
    
    //public string[] usinas;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        aud = GetComponent<AudioSource>();
        Inicializar();
    }

    public void Inicializar()
    {
        ChecarFase();
        tempoAtual = tempoTotal;
        metaAtual = (int)metaBaseAtual + deficitMeta;
        //metaAtual = (int) metaBaseAtual + PlayerPrefs.GetInt("DEFICITMETA",0);
        textoMeta.text = distribuicaoAtual + "/" + metaAtual;
    }

    public void ChecarFase()
    {
        // Esse metodo serve para checar em qual fase (ano atual) o jogador está.
        
       // anoAtual = PlayerPrefs.GetInt("ANOATUAL", 2026);

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
            textoMeta.text = distribuicaoAtual + "/" + metaAtual;
        }
        
        // Se o tempo acabar e o jogador não tiver atingido a meta acontece isso (tela de derrota):
        
        else
        {
            distribuicaoAtual = 0;
            ControlarGrafico.instance.ZerarGrafico();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            painelDePausa.SetActive(!painelDePausa.activeSelf);

            if (painelDePausa.activeSelf)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
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
            
            if (distribuicaoAtual < metaAtual && !anoFinal)
            {
                cumpriuMeta = false;
                //PlayerPrefs.SetInt("DEFICITMETA",metaAtual - energiaAtual);
                deficitMeta = metaAtual - distribuicaoAtual;
                painelDeMetaNaoConcluida.SetActive(true);
                acabou = true;
                
                // Acabou o tempo sem bater a meta
            }
        }
        
        // Definindo o tempo do cronometro:
        
        cronometro = TimeSpan.FromSeconds(tempoAtual);
        textoTimer.text = cronometro.ToString(@"mm\:ss");
       
        // Confere se o jogador concluiu a meta e chama a vitoria
        
        if (tempoAtual > 0 && distribuicaoAtual >= metaAtual && !anoFinal)
        {
            cumpriuMeta = true;

            painelDeMetaConcluida.SetActive(true);
            acabou = true;
            
            // Acabou batendo a meta
        }


        if (anoAtual == 2030)
        {
            anoFinal = true;

            // Verificando se perdeu

            if (tempoAtual <= 0 && distribuicaoAtual < metaAtual)
            {
                volumeDoLoop.volume = 0;
                painelDeDerrota.SetActive(true);
            }

            else if (tempoAtual > 0 && distribuicaoAtual >= metaAtual)
            {
                volumeDoLoop.volume = 0;
                painelDeVitoria.SetActive(true);
            }
        }
    }

    public void Cliques()
    {
        // Faz os cliques no painel piezoeletrico adicionarem pontos a energia atual

        //aud.volume = 0.2f;
        aud.PlayOneShot(somCliqueNoPainelPiezo,0.2f);
        energiaAtual += valorPorClique;
        textoEnergiaAtual.text = energiaAtual.ToString();
        
    }

    public void Passarfase()
    { 
        acabou = false;

        painelDeMetaConcluida.SetActive(false);
        painelDeMetaNaoConcluida.SetActive(false);
        // PlayerPrefs.SetInt("ANOATUAL", anoAtual + 1);

        anoAtual++;
        tempoTotal -= 60;
        Inicializar();
        VenderEnergiaNoFimDoAno();

        cumpriuMeta = false;
    }

    public void VenderEnergia()
    {
        if (energiaAtual > 0)
        {
            aud.PlayOneShot(somVenderEnergia, 0.6f);

            dinheiroAtual += energiaAtual;
            distribuicaoAtual += energiaAtual;
            energiaAtual = 0;

            textoEnergiaAtual.text = energiaAtual.ToString();
            textoDinheiro.text = dinheiroAtual.ToString();

            objParticulas.AtivarParticulasDinheiro();
            
            ControlarGrafico.instance.AtualizarGrafico();
        }
    }

    public void VenderEnergiaNoFimDoAno()
    {
        if (energiaAtual > 0)
        {
            aud.PlayOneShot(somVenderEnergia, 0.6f);

            dinheiroAtual += energiaAtual;

            if(cumpriuMeta == false)
            {
                distribuicaoAtual += energiaAtual;
            }

            energiaAtual = 0;

            textoEnergiaAtual.text = energiaAtual.ToString();
            textoDinheiro.text = dinheiroAtual.ToString();

            ControlarGrafico.instance.AtualizarGrafico();
        }
    }

    public bool FazerCompra(int preco)
    {
        bool sucesso = false;
        
        if (dinheiroAtual >= preco)
        {
            sucesso = true;
            dinheiroAtual -= preco;

            aud.PlayOneShot(somVenderEnergia, 0.8f);
            //atualiza interface
            textoDinheiro.text = dinheiroAtual.ToString();
        }

        return sucesso;
    }
    public bool GastarPontosPesquisa(int precoEmPontos)
    {
        bool sucesso1 = false;

        if (pontosPesquisaAtual >= precoEmPontos)
        {
            sucesso1 = true;
            pontosPesquisaAtual -= precoEmPontos;
            aud.PlayOneShot(somGastarPontosPesquisa, 0.8f);
            //atualiza interface
            textoPontosPesquisaAtual.text = pontosPesquisaAtual.ToString();
        }

        return sucesso1;
    }
}
