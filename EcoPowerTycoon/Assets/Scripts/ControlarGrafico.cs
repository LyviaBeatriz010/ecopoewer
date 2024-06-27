using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlarGrafico : MonoBehaviour
{
    public static ControlarGrafico instance;

    public float valor;

    public Image imagemDoGrafico;

    public TextMeshProUGUI textoDaPorcentagem;
    // Start is called before the first frame update
    void Start()
    {
        imagemDoGrafico = GetComponent<Image>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameManager.instance)
       // AtualizarGrafico();
    }

    public void AtualizarGrafico()
    {
        valor = (float)GameManager.instance.distribuicaoAtual / GameManager.instance.metaAtual;
        Debug.Log(valor);

        //atualizar a img

        imagemDoGrafico.fillAmount = valor;


        //atualizar texto de %

        textoDaPorcentagem.text = (valor * 100).ToString("F") + " %";
    }

    public void ZerarGrafico()
    {
        imagemDoGrafico.fillAmount = 0;
        valor = 0;
        
        textoDaPorcentagem.text = (valor * 100).ToString("F") + " %";
    }
    
}
