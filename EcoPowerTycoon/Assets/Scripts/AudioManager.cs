using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
 {
    private AudioSource aud;
    public AudioClip loopDoMenu;
    public AudioClip loopDoGame;

    private int indiceDaCena;
    private int cenaAtual;

    public bool trocarDeMusica = true;
    
    public float volume;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        aud = GetComponent<AudioSource>();
        indiceDaCena = SceneManager.GetActiveScene().buildIndex;
        cenaAtual = indiceDaCena;
        TocarMusica(indiceDaCena);
    }

    void Update()
    {
        indiceDaCena = SceneManager.GetActiveScene().buildIndex;
        if (indiceDaCena != cenaAtual)
        {
            cenaAtual = indiceDaCena;
            TocarMusica(indiceDaCena);
        }
    }

    void TocarMusica(int indiceDaCena)
    {
        if (aud.isPlaying)
        {
            aud.Stop();
        }

        if (indiceDaCena == 0 )
        {
            aud.clip = loopDoMenu;
        }
        
        else if (indiceDaCena == 2)
        {
            aud.clip = loopDoGame;
        }
        if (aud.clip != null)
        {
            aud.Play();
        }

    }
    private void OnEnable()
    {
        AudioObserver.OnVolumeChanged += ProcessVolumeChanged;
    }

    private void ProcessVolumeChanged(float value)
    {
        aud.volume = value;
    }

    private void OnDisable()
    {
        AudioObserver.OnVolumeChanged -= ProcessVolumeChanged;
    }
 }


