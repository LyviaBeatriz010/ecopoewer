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

    public TextMeshProUGUI textoBotaoI;
    public TextMeshProUGUI textoBotaoII;
    public TextMeshProUGUI textoBotaoIII;





    [SerializeField] private Animator myFSM;

    void Start()
    {
        myFSM = GetComponent<Animator>();
    }

    public void AtivarPainelCentrosDePesquisa()
    {
        myFSM.SetTrigger("AtivarCentrosDePesquisa");
    }

    public void AtivarPainelMeiosDeProducao()
    {
        myFSM.SetTrigger("AtivarMeiosDeProducao");
    }

    public void AtivarPainelMelhorias()
    {
        myFSM.SetTrigger("AtivarMelhorias");
    }
}
