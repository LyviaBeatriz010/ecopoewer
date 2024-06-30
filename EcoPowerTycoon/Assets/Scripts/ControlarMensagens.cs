using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlarMensagens : MonoBehaviour
{
    public static ControlarMensagens instance;

    public TextMeshProUGUI mensagemAtual;
    public TextMeshProUGUI mensagemAleatoria;

    public string[] mensagensAleatorias = { "Mensagem1", "Mensagem2", "Mensagem3" };

    public string mensagemInicial = "Oii!! Eu sou o Lithinho mascote dessa iniciativa ecologica" +
        " da uni�o ecotlanta e voc� � o respons�vel pela secretaria de distribui��o energ�tica do uni�o ecotlanta ";

   
    void Start()
    {
        instance = this;
        mensagemAleatoria.text = mensagemInicial;
        StartCoroutine(Intervalo());
    }

    
    public void MensagemDeDesbloqueioUsina()
    {
        mensagemAtual.text = "Uau!! voc� desbloqueou uma usina, agora voc� produz 5GWZ/s. Estamos a todo vapor!";
    }

    public void MensagemDesbloqueioCentro()
    {
        mensagemAtual.text = "Voc� sabia que com pontos de pesquisa � possivel descobrir novos meios de produ��o e ainda melhora - los ";
    }
    public void MensagemDesbloqueioMelhorias()
    {
        mensagemAtual.text = "Ecotlanta agradece por sempre buscar a melhor maneira de distribuir energia de forma ecologica.";
    }

    IEnumerator Intervalo()
    {
            yield return new WaitForSeconds(5f);    
        while (true)
        {
            if (mensagensAleatorias.Length > 0)
            {
                int random = Random.Range(0, mensagensAleatorias.Length);
                mensagemAleatoria.text = mensagensAleatorias[random];
            }
            yield return new WaitForSeconds(5f);
        }
    }

}
