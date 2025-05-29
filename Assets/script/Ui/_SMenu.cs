using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _SMenu : MonoBehaviour
{

    public string SceneMenu;

    public Image BGImage;


    public int intImage;
    public Sprite[] BGPIC;



    public GameObject Setting;
    public GameObject meNu;

    // Start is called b
    // efore the first frame update
    void Start()
    {
        Rendom();

    }
   
   
    void Update()
    {
        BGImage.sprite = BGPIC[intImage];

    }
    public void Rendom()
    {
        intImage = UnityEngine.Random.Range(0, BGPIC.Length);

    }
    public void LoadSceneBotton()
    {

        SceneManager.LoadScene(SceneMenu);
        print("LoadSceneBotton");
    }
    public void _Setting()
    {
        Setting.SetActive(true);
        meNu.SetActive(false);
        print("_Setting");

    }
    public void Q_Setting()
    {
        Setting.SetActive(false);
        meNu.SetActive(true);


    }




}



