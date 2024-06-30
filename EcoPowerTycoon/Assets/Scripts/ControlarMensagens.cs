using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlarMensagens : MonoBehaviour
{
    public static ControlarMensagens instance;

    public TextMeshProUGUI mensagemAleatoria;

    public string[] mensagensAleatorias = { "Mensagem1", "Mensagem2", "Mensagem3" };

    public string mensagemInicial = "Oii!! Eu sou o Lithinho mascote dessa iniciativa ecologica" +
        " da união ecotlanta e você é o responsável pela secretaria de distribuição energética do união ecotlanta ";

    public bool sorteando = true;

   
    void Start()
    {
        instance = this;
        mensagemAleatoria.text = mensagemInicial;
        StartCoroutine(Intervalo());
    }

    
    public void MensagemDeDesbloqueioUsina()
    {
        mensagemAleatoria.text = "Uau!! Você desbloqueou uma usina. Estamos a todo vapor!";
    }

    public void MensagemDesbloqueioCentro()
    {
        mensagemAleatoria.text = "Você sabia que com pontos de pesquisa é possivel descobrir novos meios de produção e ainda melhora - los ";
    }
    public void MensagemDesbloqueioMelhorias()
    {
        mensagemAleatoria.text = "Ecotlanta agradece por sempre buscar a melhor maneira de distribuir energia de forma ecologica.";
    }

   public IEnumerator Intervalo()
    {
        yield return new WaitForSeconds(40f);

        sorteando = true;

        while (sorteando)
        {
            if (mensagensAleatorias.Length > 0)
            {
                int random = Random.Range(0, mensagensAleatorias.Length);
                mensagemAleatoria.text = mensagensAleatorias[random];
            }

        yield return new WaitForSeconds(40f);
        }
    }
}
