using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OFFCorDasAbasBehaviour : StateMachineBehaviour
{
    public GameObject painelInativo; 
    private GerenciarAbas gerenciarAbas;

    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (gerenciarAbas == null)
        {
            gerenciarAbas = FindObjectOfType<GerenciarAbas>();
        }

        if (gerenciarAbas != null)
        {
          
            if (painelInativo == gerenciarAbas.painelDeCentrosDePesquisa)
                gerenciarAbas.AtualizarBotao(gerenciarAbas.botaoQueAtivaPainelCentrosDePesquisa, false);
            else if (painelInativo == gerenciarAbas.painelDeMeiosdeProducao)
                gerenciarAbas.AtualizarBotao(gerenciarAbas.botaoQueAtivaPainelMeiosDeProducao, false);
            else if (painelInativo == gerenciarAbas.painelDeMelhorias)
                gerenciarAbas.AtualizarBotao(gerenciarAbas.botaoQueAtivaPainelMelhorias, false);
        }
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
