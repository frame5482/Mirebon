using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogeePatterns : MonoBehaviour
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

    public Textbase1 textbase;


    private int currentLineIndex = 0;
    private LanguageContext languageContext = new LanguageContext();
    public string SceneName;

    void Start()
    {
        ApplyLanguageSetting();
        ShowCurrentLine();
    }

    void Update()
    {
        ShowCurrentLine();

        ApplyLanguageSetting();
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
            SceneManager.LoadScene(SceneName);
        }
    }

    void ApplyLanguageSetting()
    {
        int setLang = PlayerPrefs.GetInt("PlayerPrefsSetLanguage");
        if (setLang == 0)
        {
            languageContext.SetStrategy(new ENGStrategy());
            ThaiGameObject.SetActive(false);
            ENGGameObject.SetActive(true);
            JPGameObject.SetActive(false);

        }
        else if (setLang == 1)
        {
            languageContext.SetStrategy(new THAIStrategy());
            ThaiGameObject.SetActive(true);
            ENGGameObject.SetActive(false);
            JPGameObject.SetActive(false);

        }
        if (setLang == 2)
        {
            languageContext.SetStrategy(new JPStrategy());
            ThaiGameObject.SetActive(false);
            ENGGameObject.SetActive(false);
            JPGameObject.SetActive(true);
        }

    }


    void ShowCurrentLine()
    {
        TextLine line = textbase.TextData[currentLineIndex];

        speakerNameText.text = line.speakerName;

        characterImage.sprite = line.speakerImage;
        characterImageSmall.sprite = line.SmallImage;

        _BGImage.sprite = line.BGImage;
        _StoryImage.sprite = line.StoryImage;

        JPdialogueText.text = line.Jpsentence;
        ENGdialogueText.text = line.ENGsentence;
        ThaidialogueText.text = line.Thaisentence;
    }

}