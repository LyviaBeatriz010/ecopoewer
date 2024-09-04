using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CentroDePesquisaBehaviour : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GerenciarAbas gerenciador = animator.GetComponent<GerenciarAbas>();
        
        gerenciador.painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().alpha = 1.0f;
        gerenciador.painelDeCentrosDePesquisa.GetComponent<CanvasGroup>().interactable = true;
        gerenciador.painelDeCentrosDePesquisa.transform.SetAsLastSibling();
 
        gerenciador.painelDeMeiosdeProducao.GetComponent<CanvasGroup>().alpha = 0.0f;
        gerenciador.painelDeMelhorias.GetComponent<CanvasGroup>().alpha = 0.0f;
 
        gerenciador.botaoQueAtivaPainelCentrosDePesquisa.GetComponent<Image>().color = new Color(2f / 255f, 61f / 255f, 97f / 255);
        gerenciador.botaoQueAtivaPainelMeiosDeProducao.GetComponent<Image>().color = new Color(246f / 255f, 249f / 255f, 145f / 255);
        gerenciador.botaoQueAtivaPainelMelhorias.GetComponent<Image>().color = new Color(246f / 255f, 249f / 255f, 145f / 255);

        gerenciador.textoBotaoI.color = Color.gray;
        gerenciador.textoBotaoII.color = Color.black;
        gerenciador.textoBotaoIII.color = Color.black;

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
