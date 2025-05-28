using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

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

 

    public enum Language { ENG, THAI, JP }
    public Language currentLanguage = Language.THAI;

    public int currentLineIndex = 0;

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
}