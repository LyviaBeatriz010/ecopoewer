using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioObserver 
{
    public static event Action<float> OnVolumeChanged;

    public static void VolumeChanged(float volume)
    {
        OnVolumeChanged?.Invoke(volume);
    }
}
