﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer audioMixer;


    public void Volumeslider (float Volume)
    {
        Debug.Log(Volume);
        audioMixer.SetFloat("Volume", Volume); 
    }

}
