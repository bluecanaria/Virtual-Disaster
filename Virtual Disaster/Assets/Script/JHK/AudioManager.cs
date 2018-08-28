using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    //테스트용
    public Slider BGMSlider;
    public Slider SoundSlider;
    public AudioSource BGMClip;
    //public AudioSource[] BGM;
    //public AudioSource[] Sound = new AudioSource[10];

    //인게임에서는 PlayerPrefs.GetFloat로 소리를 불러오게 한다.

    public void Start()
    {
        PlayerPrefs.SetFloat("BGMVolume", 1);
        PlayerPrefs.SetFloat("SoundVolume", 1);
        //BGMSlider.value = PlayerPrefs.GetFloat("BGMVolume");
        //SoundSlider.value = PlayerPrefs.GetFloat("SoundVolume");
    }

    public void setBGMVolume(float vol)
    {
        PlayerPrefs.SetFloat("BGMVolume", vol);
    }

    public void setSoundVolume(float vol)
    {
        PlayerPrefs.SetFloat("SoundVolume", vol);
    }

    public void FixedUpdate()
    {
        BGMClip.volume = PlayerPrefs.GetFloat("BGMVolume");
    }

}
