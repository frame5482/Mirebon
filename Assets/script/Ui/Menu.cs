using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Image BGImage;


    public int intImage;
    public Sprite[] BGPIC;
    public Sprite chapterBG;



    public GameObject Stage;

    public GameObject _Menu;
    // Start is called before the first frame update
    void Start()
    {
        Rendom();
        BGImage.sprite = BGPIC[intImage];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rendom()
    {
        intImage = UnityEngine.Random.Range(0, BGPIC.Length);

    }
    public void LoadSceneBotton(string SceneMenu)
    {
        print("LoadSceneBotton");
        SceneManager.LoadScene(SceneMenu);
       
    }




    public void OpenStage()
    {
        Stage.SetActive(true);
        _Menu.SetActive(false);
        BGImage.sprite = chapterBG;

    }
    public void OpenMenu()
    {
        Stage.SetActive(false);
        _Menu.SetActive(true);
        Rendom();
        BGImage.sprite = BGPIC[intImage];
    }

    public void Quit()
    {
        Application.Quit();
    }



}
