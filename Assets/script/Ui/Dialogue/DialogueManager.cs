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

    public Textbase textbase; // อ้างอิงไปยัง Textbase (ลากจาก Inspector)

    public enum Language { ENG, THAI, JP }
    public Language currentLanguage = Language.THAI;

    public int currentLineIndex = 0;

    void Start()
    {

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