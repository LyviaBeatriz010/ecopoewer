using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    public static Particulas instance;
    public GameObject particulasDinheiro;
    public GameObject particulasPesquisa;


    private void Start()
    {
        instance = this;
    }

    public void AtivarParticulasDinheiro()
    {
        particulasDinheiro.SetActive(true);
        StartCoroutine(DesativarParticulasDinheiro(1.4f));  
    }

    private IEnumerator DesativarParticulasDinheiro(float time)
    {
        yield return new WaitForSeconds(time);
        particulasDinheiro.SetActive(false);
    }

   
    public void AtivarParticulasPesquisa()
    {
        particulasPesquisa.SetActive(true);
       
    }
}
