using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

 


    public TextMeshProUGUI speakerNameText;
    public TextMeshProUGUI JPdialogueText;
    public TextMeshProUGUI ENGdialogueText;
    public TextMeshProUGUI ThaidialogueText;
    public Image characterImage;
    public Image characterImageSmall;

    public Image _BGImage;
    public Image _StoryImage;



    public Textbase textbase;


    private static readonly string SetLanguage = "PlayerPrefsSetLanguage";
    public int SetintLanguage;
    public enum Language { ENG, THAI, JP }
    public Language currentLanguage = Language.THAI;

    public int currentLineIndex = 0;


    public string SceneName;


    void Start()
    {   
        speakerNameText = GameObject.Find("Name")?.GetComponent<TextMeshProUGUI>();
        JPdialogueText = GameObject.Find("Jp")?.GetComponent<TextMeshProUGUI>();
        ENGdialogueText = GameObject.Find("ENG")?.GetComponent<TextMeshProUGUI>();
        ThaidialogueText = GameObject.Find("TH")?.GetComponent<TextMeshProUGUI>();
        characterImage = GameObject.Find("Cha")?.GetComponent<Image>();
        characterImageSmall = GameObject.Find("EmtyCurrantTurn")?.GetComponent<Image>();
        _BGImage = GameObject.Find("BG")?.GetComponent<Image>();
        _StoryImage = GameObject.Find("Storypic")?.GetComponent<Image>();

        ShowCurrentLine();
    }

    public void Update()
    {
        ShowCurrentLine();
        Language_setting();


    }
    public void OnNextButtonPressed()
    {
        
        currentLineIndex++;

        if (currentLineIndex < textbase.TextData.Count)
        {
            ShowCurrentLine();
        }
        else
        {
            Debug.Log("End of Dialogue");
            LoadScene();

        }
    }

    void ShowCurrentLine()
    {
        var line = textbase.TextData[currentLineIndex];


        speakerNameText.text = line.speakerName;

        characterImage.sprite = line.speakerImage;
        characterImageSmall.sprite = line.SmallImage;

        _BGImage.sprite = line.BGImage;
        _StoryImage.sprite = line.StoryImage;


        if (currentLanguage == Language.JP)
        {
            Debug.Log("Language.JP");
            JPdialogueText.text = line.Jpsentence;

        }
        else if (currentLanguage == Language.ENG)
        {
            Debug.Log("Language.ENG");
            ENGdialogueText.text = line.ENGsentence;

        }
        else if (currentLanguage == Language.THAI)
        {
            Debug.Log("Language.THAI");
            ThaidialogueText.text = line.Thaisentence;

        }
    }

    public void LoadScene() 
    {
        SceneManager.LoadScene(SceneName);

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

}