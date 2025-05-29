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


    public GameObject JPGameObject;
    public GameObject ENGGameObject;
    public GameObject ThaiGameObject;

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

        JPdialogueText = GameObject.Find("JP")?.GetComponent<TextMeshProUGUI>();
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
        JPGameObject = JPdialogueText.gameObject;
        ThaiGameObject = ThaidialogueText.gameObject;
        ENGGameObject = ENGdialogueText.gameObject;
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
            LoadScene();
            Debug.Log("End of Dialogue");
           

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

            Debug.Log("Language.JP");
            JPdialogueText.text = line.Jpsentence;
            
       
            Debug.Log("Language.ENG");
            ENGdialogueText.text = line.ENGsentence;
       
       
            Debug.Log("Language.THAI");
            ThaidialogueText.text = line.Thaisentence;

        
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
            currentLanguage = Language.ENG;
            ThaiGameObject.SetActive(false);
            ENGGameObject.SetActive(true);
            JPGameObject.SetActive(false);
           
        }
        else if (SetintLanguage == 1)
        {
            currentLanguage = Language.THAI;
            ThaiGameObject.SetActive(true);
            ENGGameObject.SetActive(false);
            JPGameObject.SetActive(false);

        }
        if (SetintLanguage == 2)
        {
            currentLanguage = Language.JP;
            ThaiGameObject.SetActive(false);
            ENGGameObject.SetActive(false);
            JPGameObject.SetActive(true);
        }

    }

}