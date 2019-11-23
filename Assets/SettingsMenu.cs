using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour

{
    public Slider slider;
    private float volume;

    public void SetVolume(float vol) {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        float sliderValue = slider.value;

        Debug.Log(sliderValue);
    }

}
