using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public GameObject particulaDeDinheiro;

    public void OnEnable()
    {
        ParticleObserver.InstanciarParticulasDeDinheiroEvent += InstanciarParticulasDeDinheiro;
    }
    
    public void OnDisable()
    {
        ParticleObserver.InstanciarParticulasDeDinheiroEvent -= InstanciarParticulasDeDinheiro;
    }
    
    public void InstanciarParticulasDeDinheiro(Vector3 posicao)
    {
        Instantiate(particulaDeDinheiro, posicao, Quaternion.identity);
    }
}
