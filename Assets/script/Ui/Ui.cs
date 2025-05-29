using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;


public class Ui : MonoBehaviour
{
    
    public Canvas canvas;
    public TextMeshProUGUI Mire;
    public int MirePoint =  5;
    public Units _unit;

    public GameController _GameController;


    public GameObject _Curser;

    public GameObject AttackOpen;
    public GameObject AttackClose;


    public GameObject[] OnUse;

    public string SceneMenu;

    public GameObject Dead;
    public GameObject Win;

    public Image WinBGImage;
    public Image loseBGImage;

    public int intImage;
    public Sprite[] BGPIC ;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        _GameController = FindObjectOfType<GameController>();

        _Curser = FindObjectOfType<Curser>().gameObject;
        Rendom();


    }

    // Update is called once per frame
    void Update()
    {
        Mire.text = "" + MirePoint ;

       
    }

  


    public void IsWin(bool iswin)
    {
        
        if (iswin == true)
        {
           
            WinBGImage.sprite = BGPIC[intImage];
            Win.SetActive(true);
            Dead.SetActive(false);
        
            
        }
        else if (iswin == false) 
        {
          
            loseBGImage.sprite = BGPIC[intImage];
            Dead.SetActive(true);
            Win.SetActive(false);
            

        }

    }

    public void Rendom()
    {
        intImage = UnityEngine.Random.Range(0, BGPIC.Length);

    }
    public void LoadSceneBotton()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneMenu);

    }
    public void _getPlayer(Units _Units)
    {
        _unit = _Units; ;
    }

    public void _AttackOpen()
    {
        AttackOpen.SetActive(true);
        AttackClose.SetActive(false);
        _Curser.SetActive(true);
        print("AttackOpen");
        _GameController.closeselectTrueOrfalse(false);
    }
    public void _AttackClose()
    {
        AttackOpen.SetActive(false);
        AttackClose.SetActive(true);
        _Curser.SetActive(false);
        _unit.cancer();
        print("_AttackClose");
        _GameController.closeselectTrueOrfalse(true);
        CloseOnuse();


    }


    public void CALL_Skill_1()
    {
        _unit.GETKEY_Q();
        print("CALL_Skill_1");
    
    }
    public void CALL_Skill_2()
    {
        _unit.GETKEK_W();
        print("CALL_Skill_2");
      

    }

    public void CALL_Skill_3()
    {
        _unit.GETKEK_E();
        print("CALL_Skill_3");
       

    }
    public void CALL_EX()
    {
        _unit.GETKEY_R_EX();
        print("CALL_EX");
    

    }
  



    public void OnUse_1()
    {
    
        OnUse[0].SetActive(true);
    }
    public void OnUse_2()
    {
        
        OnUse[1].SetActive(true);

    }

    public void OnUse_3()
    {
       
        OnUse[2].SetActive(true);

    }
    public void OnUse_4()
    {
        
        OnUse[3].SetActive(true);

    }
    public void CloseOnuse()
    {

        OnUse[0].SetActive(false);
        OnUse[1].SetActive(false);
        OnUse[2].SetActive(false);
        OnUse[3].SetActive(false);


    }

    public void Quit()
    {
        Debug.Log("Q ถูกเรียกเมื่อคลิก!");
        print("QQ");
         
            
    }

}
