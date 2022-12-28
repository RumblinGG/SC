using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OP : MonoBehaviour
{
public AudioMixer audioMixer;
public void SetVolume(float Volume)
{
audioMixer.SetFloat("Volume", Mathf.Log10(Volume)*20);
}

public void SetQuality (int qualityIndex) 
{
    QualitySettings.SetQualityLevel(qualityIndex);        
}
public void Sound ()
{
    AudioListener.pause = !AudioListener.pause;      
}
}

