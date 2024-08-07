using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCustom : MonoBehaviour
{
     public RectTransform pezinho;
     public Camera maincam;

     private void Update()
     {
          Vector3 mousePosition = Input.mousePosition;
          Vector3 worldPosition = maincam.ScreenToWorldPoint(mousePosition);

          worldPosition.z = 0;
          pezinho.position = worldPosition;
          
     }
     
}
