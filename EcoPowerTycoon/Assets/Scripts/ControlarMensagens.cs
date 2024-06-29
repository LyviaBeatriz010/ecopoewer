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
        mensagemAtual.text = "Uau!! voc� desbloqueou uma usina, agora voc� produz 5GWZ/s. Estamos a todo vapor!";
    }

    public void MensagemDesbloqueioCentro()
    {
        mensagemAtual.text = "Voc� sabia que com pontos de pesquisa � possivel descobrir novos meios de produ��o e ainda melhora - los ?";
    }
    public void MensagemDesbloqueioMelhorias()
    {
        mensagemAtual.text = "Ecotlanta agradece por sempre buscar a melhor maneira de distribuir energia de forma ecologica.";
    }

    public void MensagemDeCompraDeUsinaEolica()
    {
        mensagemAtual.text = "Voc� sabia que a energia e�lica � sustentavel porque ela ultiliza um recurso que � " +
            "reutilizavel, o vento, mas que as turbinas proximas as casas atrapalham a qualidade de vida das pessoas?";
    }
}
