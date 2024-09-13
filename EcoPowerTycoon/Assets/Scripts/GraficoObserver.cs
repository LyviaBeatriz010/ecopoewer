using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GraficoObserver 
{
    public static event Action GraficoEmptyEvent;

    public static void OnGraficoEmptyEvent()
    {
        GraficoEmptyEvent?.Invoke();
    }
}
