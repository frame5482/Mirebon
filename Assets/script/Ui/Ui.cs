using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


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


    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        _GameController = FindObjectOfType<GameController>();

        _Curser = FindObjectOfType<Curser>().gameObject;

     
    }

    // Update is called once per frame
    void Update()
    {
        Mire.text = "" + MirePoint ;

       
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

   

    public void Quit()
    {
        Debug.Log("Q ถูกเรียกเมื่อคลิก!");
        print("QQ");
         
            
    }

}
