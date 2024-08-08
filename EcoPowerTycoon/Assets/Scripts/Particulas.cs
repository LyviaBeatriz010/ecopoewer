using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
     public GameObject particulas;

    public void AtivarParticulas()
    {
        particulas.SetActive(true);
        StartCoroutine(DesativarParticulas(1.4f));  
    }

    private IEnumerator DesativarParticulas(float time)
    {
        yield return new WaitForSeconds(time);
        particulas.SetActive(false);
    }
}
