using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinheiroController : MonoBehaviour
{
    private void OnEnable()
    {
        DinheiroObserver.DinheiroContarEvent += DinheiroAtualizado;
        DinheiroObserver.DinheiroTextoEvent += TextoDinheiroAtualizado;
    }

    private void OnDisable()
    {
        DinheiroObserver.DinheiroContarEvent -= DinheiroAtualizado;
        DinheiroObserver.DinheiroTextoEvent -= TextoDinheiroAtualizado;
    }

    public void DinheiroAtualizado(int atualEnergia)
    {
       GameManager.instance.dinheiroAtual += GameManager.instance.energiaAtual;
    }

    public void TextoDinheiroAtualizado(string dinheiroText)
    {
        GameManager.instance.textoDinheiro.text = dinheiroText;
    }
}
