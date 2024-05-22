using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Usina : MonoBehaviour
{ 
   public EcoEnum.TipoProducao tipodeProducao;
   public int preco;
   public int producao;
   public int quantidadeEmpresas;
   public bool vendido;

   public void UpdateUsinas()
   {
      quantidadeEmpresas += 1;
   }
}
