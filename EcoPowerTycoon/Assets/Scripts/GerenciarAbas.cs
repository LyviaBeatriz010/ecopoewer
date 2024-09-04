using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GerenciarAbas : MonoBehaviour
{
    public GameObject painelAtivo;
    public GameObject painelDeCentrosDePesquisa;
    public GameObject painelDeMeiosdeProducao;
    public GameObject painelDeMelhorias;

    public GameObject botaoQueAtivaPainelCentrosDePesquisa;
    public GameObject botaoQueAtivaPainelMeiosDeProducao;
    public GameObject botaoQueAtivaPainelMelhorias;

    [SerializeField] private Animator myFSM;

    public void AtivarPainelDeCentrosDePesquisa()
    {
        AtualizarPainel(painelDeCentrosDePesquisa);
        AtualizarBotao(botaoQueAtivaPainelCentrosDePesquisa, true);
        AtualizarBotao(botaoQueAtivaPainelMeiosDeProducao, false);
        AtualizarBotao(botaoQueAtivaPainelMelhorias, false);
        myFSM.SetBool("Ativar", true);
        myFSM.SetBool("Desativar", false);
    }

    public void AtivarPainelDeMeiosDeProducao()
    {
        AtualizarPainel(painelDeMeiosdeProducao);
        AtualizarBotao(botaoQueAtivaPainelCentrosDePesquisa, false);
        AtualizarBotao(botaoQueAtivaPainelMeiosDeProducao, true);
        AtualizarBotao(botaoQueAtivaPainelMelhorias, false);
        myFSM.SetBool("Ativar", true);
        myFSM.SetBool("Desativar", false);
    }

    public void AtivarPainelDeMelhorias()
    {
        AtualizarPainel(painelDeMelhorias);
        AtualizarBotao(botaoQueAtivaPainelCentrosDePesquisa, false);
        AtualizarBotao(botaoQueAtivaPainelMeiosDeProducao, false);
        AtualizarBotao(botaoQueAtivaPainelMelhorias, true);
        myFSM.SetBool("Ativar", true);
        myFSM.SetBool("Desativar", false);
    }

    private void AtualizarPainel(GameObject painelAtivo)
    {
        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = painelAtivo == painelDeCentrosDePesquisa ? 1.0f : 0.0f;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = painelAtivo == painelDeMeiosdeProducao ? 1.0f : 0.0f;
        painelDeMelhorias.GetComponent<CanvasGroup>().alpha = painelAtivo == painelDeMelhorias ? 1.0f : 0.0f;

        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = painelAtivo == painelDeCentrosDePesquisa;
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().interactable = painelAtivo == painelDeMeiosdeProducao;
        painelDeMelhorias.GetComponent<CanvasGroup>().interactable = painelAtivo == painelDeMelhorias;

        painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().transform.SetAsLastSibling();
        painelDeMeiosdeProducao.GetComponent<CanvasGroup>().transform.SetAsLastSibling();
        painelDeMelhorias.GetComponent<CanvasGroup>().transform.SetAsLastSibling();
    }

    public void AtualizarBotao(GameObject botao, bool ativo)
    {
        Color cor = ativo ? new Color(2f / 255f, 61f / 255f, 97f / 255f) : new Color(246f / 255f, 249f / 255f, 145f / 255f);
        Color textoCor = ativo ? new Color(150f / 255f, 150f / 255f, 150f / 255f) : Color.black;
        
        botao.GetComponent<Image>().color = cor;
        botao.GetComponentInChildren<TMP_Text>().color = textoCor;
    }
}
