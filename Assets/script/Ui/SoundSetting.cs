using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SounddSetting : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";


    private int firstPlayInt;
    public Slider backgroundslider, soundEffectsSlider;

    private float backgroundFloat, soundEffectsFloat;
    public AudioSource BackgroundAudio;
    public AudioSource[] SoundEffectsAudio;

    public GameObject Setting;

    public enum Language { ENG, THAI, JP }

    private static readonly string SetLanguage = "PlayerPrefsSetLanguage";
    public int SetintLanguage;
    public Language currentLanguage = Language.THAI;




    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        SetintLanguage = PlayerPrefs.GetInt(SetLanguage);


        if (firstPlayInt == 0)
        {
            backgroundFloat = .125f; soundEffectsFloat = .75f;
            backgroundslider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;


            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundslider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsSlider.value = soundEffectsFloat;

        }


      
    }
    public void Update()
    {
        if (SetintLanguage == 0)
        {
            currentLanguage = Language.THAI;
        }
        else if (SetintLanguage == 1)
        {
            currentLanguage = Language.ENG;
        }
        if (SetintLanguage == 0)
        {
            currentLanguage = Language.JP;
        }

    }






    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundslider.value);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);

    }

    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        BackgroundAudio.volume = backgroundslider.value;
        for (int i = 0; i < SoundEffectsAudio.Length; i++)
        {
            SoundEffectsAudio[i].volume = soundEffectsSlider.value;

        }
    }

    public void Update_SettingOpen()
    {
        Setting.SetActive(true);

    }
    public void Update_SettingExit()
    {
        Setting.SetActive(false);
    }
}