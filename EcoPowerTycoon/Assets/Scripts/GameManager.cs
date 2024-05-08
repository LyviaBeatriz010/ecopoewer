using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int valorCliques = 1;
    public int valorInicial = 0;
    public TextMeshProUGUI textoCliques;

    public TextMeshProUGUI textoTimer;

    public float tempoTotal = 70;
    public float tempoAtual;
  
    private TimeSpan cronometro;
    
    
   
    void Start()
    {
        Cliques();

        tempoAtual = tempoTotal;
    }

    // Update is called once per frame
    void Update()
    {
        if (tempoAtual > 0)
        {
            tempoAtual -= Time.deltaTime;
        }
        else
        {
            tempoAtual = 0;
            
            
            
        }
        
        
        cronometro = TimeSpan.FromSeconds(tempoAtual);
        textoTimer.text = cronometro.ToString(@"mm\:ss");


    }

    public void Cliques()
    {
        valorCliques++;
        textoCliques.text = valorCliques.ToString();

    }

    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0f)
        {
            timeToDisplay = 0f;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        
    }
}
