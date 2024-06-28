using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlarMensagens : MonoBehaviour
{
    public static ControlarMensagens instance;

    public TextMeshProUGUI mensagemAtual;
    void Start()
    {
        instance = this;
    }

    public void MensagemDeDesbloqueioUsina()
    {
        mensagemAtual.text = "Você Desbloqueou uma usina";
    }
}
