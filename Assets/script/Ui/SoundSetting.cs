using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SounddSetting : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";


    private int firstPlayInt;
    public Slider backgroundslider, soundEffectsSlider;

    public float backgroundFloat, soundEffectsFloat;
    public AudioSource BackgroundAudio;
    public AudioSource[] SoundEffectsAudio;

    public GameObject SettingO;
    public GameObject SettingC;


    public enum Language { ENG, THAI, JP }

    private static readonly string SetLanguage = "PlayerPrefsSetLanguage";
    public int SetintLanguage;
    public Language currentLanguage = Language.THAI;

    public TMP_Dropdown dropdown;


    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);



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

        UpdateSound();

        Language_setting();

    }

    public void Language_setting()
        {
        SetintLanguage = PlayerPrefs.GetInt(SetLanguage);
        if (SetintLanguage == 0)
        {
            currentLanguage = Language.THAI;
        }
        else if (SetintLanguage == 1)
        {
            currentLanguage = Language.ENG;
        }
        if (SetintLanguage == 2)
        {
            currentLanguage = Language.JP;
        }

    }


    public void _dropdown()
    {
        int _DDropdown = dropdown.value;
        
       print(_DDropdown);

        PlayerPrefs.SetInt(SetLanguage, _DDropdown);
      


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
        SettingO.SetActive(true);
        SettingC.SetActive(false);
    }
    public void Update_SettingExit()
    {
        SettingC.SetActive(true);
        SettingO.SetActive(false);
    }
}