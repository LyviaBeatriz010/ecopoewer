using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class DinheiroObserver
{
     public static event Action<int> DinheiroContarEvent;

     public static event Action<string> DinheiroTextoEvent; 
    
    public static void OnDinheiroContarEvent(int obj)
        {
            DinheiroContarEvent?.Invoke(obj);
        }

    public static void OnDinheiroTextoEvent(string obj)
    {
        DinheiroTextoEvent?.Invoke(obj);
    }
}
