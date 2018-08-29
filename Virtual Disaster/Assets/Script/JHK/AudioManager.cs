using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    public Slider ThisSlider;

    //테스트용
    public AudioSource BGMClip;

    //public AudioSource[] BGM;
    //public AudioSource[] Sound = new AudioSource[10];
    private bool gazedAt;

    //인게임에서는 PlayerPrefs.GetFloat로 소리를 불러오게 한다.

    public void Start()
    {
        ThisSlider.value = PlayerPrefs.GetFloat("BGMVolume");
        BGMClip.volume = ThisSlider.value;
        //PlayerPrefs.SetFloat("BGMVolume", 0);
        //PlayerPrefs.SetFloat("SoundVolume", 0);
        //ThisSlider.value = 0;
    }

    public void Update()
    {
        if (gazedAt)
        {
            if (ThisSlider.value < 1)
            {
                if (Input.GetButtonUp("Jump"))
                {
                    ThisSlider.value += 0.2f;
                }
            }

            if (ThisSlider.value == 1)
            {
                if (Input.GetButtonUp("Jump"))
                {
                        ThisSlider.value = 0;
                }
            }
        }

    }

    public void onPointerEnter()
    {
        gazedAt = true;
    }

    public void onPointerExit()
    {
        gazedAt = false;
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
