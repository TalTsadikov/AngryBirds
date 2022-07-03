using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            LoadVolume();
        }

        else
        {
            LoadVolume();
        }
    }

    public void changeVolume()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("musicVolume", volumeValue);
        LoadVolume();
    }

    private void LoadVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat("musicVolume");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
