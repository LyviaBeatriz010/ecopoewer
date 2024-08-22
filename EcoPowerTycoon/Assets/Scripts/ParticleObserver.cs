using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ParticleObserver
{
    public static event Action<Vector3> InstanciarParticulasDeDinheiroEvent;

    public static void OnInstanciarParticulasDeDinheiroEvent(Vector3 obj)
    {
        InstanciarParticulasDeDinheiroEvent?.Invoke(obj);
    }
    
}
