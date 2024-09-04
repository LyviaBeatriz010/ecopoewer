using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class ONCorDasAbasBehaviour : StateMachineBehaviour
{
    public GameObject painelAtivo; 

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GerenciarAbas gerenciarAbas = FindObjectOfType<GerenciarAbas>();
        if (gerenciarAbas != null)
        {
            if (painelAtivo == gerenciarAbas.painelDeCentrosDePesquisa)
                gerenciarAbas.AtivarPainelDeCentrosDePesquisa();
            else if (painelAtivo == gerenciarAbas.painelDeMeiosdeProducao)
                gerenciarAbas.AtivarPainelDeMeiosDeProducao();
            else if (painelAtivo == gerenciarAbas.painelDeMelhorias)
                gerenciarAbas.AtivarPainelDeMelhorias();
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
