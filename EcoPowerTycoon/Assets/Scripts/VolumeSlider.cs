using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField]private Slider volumeSlider;
    
    
    void Start()
    {
        
    }

   
    private void VolumeSliderChanged(float volume)
    {
        
        AudioObserver.VolumeChanged(volume);
    }
    void Update()
    {
        AudioManager.instance.volume = volumeSlider.value;  
    }

}
