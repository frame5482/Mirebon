using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ATTACK : MonoBehaviour
{
    public bool OnAttack = false;
    public bool OnDMG= false;
    public bool OnENDDMG = false;
    public bool OnEND = false;

    public GameController Controller;
    public Walk _walk;
    public Units _units;
         

    public void Start()
    {
        Controller = FindObjectOfType<GameController>();

    }
    public void Start_Step()
    {
      OnAttack = true;
      OnDMG = false;
      OnENDDMG = false;
      OnEND = false;

    }
    public void _OnDMG()
    {
        OnAttack = true;
        OnDMG = true;
        OnENDDMG = false;
        OnEND = false;
    }
    public void _OnENDDMG()
    {

        OnAttack = false;
        OnDMG = false;
        OnENDDMG = true;
        OnEND = false;
    }

    public void end_Step()
    {
       
        OnAttack = false;
        OnDMG = false;
        OnENDDMG = true;
        OnEND = true;
        _units._IsPlay(false);
        _units.ATB = 0;

        _walk.Retrun();

       
        Controller.NextTurn();
       // Controller._Turn();



    }

}
