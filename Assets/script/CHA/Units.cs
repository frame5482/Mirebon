using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Units : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D physics;


    public Animator playanime;




    public float MaxHP = 2000;

    public float HP = 2000;
    public float ATK = 300;
    public float Defense = 60;
    public float LIFESTEAL = 5;
    public float Crit_Rate = 10;
    public float Crit_DMG = 50;
    public float Weakness_Reveal = 10;
    public float Weakness_DMG = 70;


    public float ATB = 50;

    public float Speed = 30;



    public bool IsPlay = false;




    public List<Units> alliance;
    public List<MON> Enemy;
    public GameController gameController;
    public ATTACK _ATTACK;

    public GameObject _Curser;
    public Ui _UII;

    public bool IsAttackOrBuff = true;

    public bool isConfirmingQ = false;
    public bool isConfirmingW = false;
    public bool isConfirmingE = false;
    public bool isConfirmingR = false;
    public bool isOrtherConfirming = false;


    public bool Skill_Q_IS_BUFF = false;
    public bool Skill_W_IS_BUFF = false;
    public bool Skill_E_IS_BUFF = false;
    public bool Skill_EX_IS_BUFF = false;
    [SerializeField]
    Walk walk;

    [SerializeField]
    Transform HpbarPlayer;

    private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {

        _Curser = FindObjectOfType<Curser>()?.gameObject;
        gameController = FindObjectOfType<GameController>();
        _UII = FindObjectOfType<Ui>();
        alliance = FindObjectsOfType<Units>().ToList();
        Enemy = FindObjectsOfType<MON>().ToList();



        initialScale = HpbarPlayer.localScale;

    }

    void Update_HPbar(float hp)
    {
        HP = Mathf.Clamp(hp, 0, MaxHP);
        float ratio = HP / MaxHP;

      
        HpbarPlayer.localScale = new Vector3(initialScale.x * ratio, initialScale.y, initialScale.z);

    }
    // Update is called once per frame
    void Update()
    {
       

        if (IsPlay == true)
        {
            Player_To_Ui();
            if (Input.GetKeyDown(KeyCode.Q))
            {
                GETKEY_Q();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                GETKEK_W();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {

                GETKEK_E();
            }


            if (Input.GetKeyDown(KeyCode.R))
            {
                GETKEY_R_EX();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                cancer();
            }



        }


        Update_HPbar(HP);
        if (HP == 0)
        {
            Destroy(gameObject);
        }
        if (ATB <= 0)
        {
            ATB = 0;
        }


    }

    public void GETKEY_Q()
    {
        if (isConfirmingQ == false && isOrtherConfirming == false)
        {
            _Curser.SetActive(true);
            if (_ATTACK.OnAttack == false)
            {
                _IsBuff(Skill_Q_IS_BUFF);
                isConfirmingQ = true;
                isOrtherConfirming = true;
                print("isConfirming");

            }

        }

        else if (isConfirmingQ == true)
        {
            if (_ATTACK.OnAttack == false)
            {
                print("Skill_1");
                if (Skill_Q_IS_BUFF == false) { walk.TakeAction(); }
                playanime.SetTrigger("Skill_1");
                cancer();
                gameController.closeselect();
            }
        }
    }

    public void GETKEK_W()
    {
        if (isConfirmingW == false && isOrtherConfirming == false)
        {
            _Curser.SetActive(true);
            if (_ATTACK.OnAttack == false)
            {
                _IsBuff(Skill_W_IS_BUFF);
                isConfirmingW = true;
                isOrtherConfirming = true;

                print("_IsBuff");
            }
        }

        else if (isConfirmingW == true)
        {

            if (_ATTACK.OnAttack == false)
            {
                print("Skill_2");

                if (Skill_W_IS_BUFF == false) { walk.TakeAction(); }
                playanime.SetTrigger("Skill_2");
                cancer();
                gameController.closeselect();
            }
        }
    }
    public void GETKEK_E()
    {
        if (isConfirmingE == false && isOrtherConfirming == false)
        {
            _Curser.SetActive(true);
            if (_ATTACK.OnAttack == false)
            {
                _IsBuff(Skill_E_IS_BUFF);
                isConfirmingE = true;
                isOrtherConfirming = true;

                print("isConfirmingW");
            }

        }
        else if (isConfirmingE == true)
        {
            if (_ATTACK.OnAttack == false)
            {
                print("Skill_3");
                if (Skill_E_IS_BUFF == false) { walk.TakeAction(); }
                playanime.SetTrigger("Skill_3");
                cancer();
                gameController.closeselect();
            }

        }
    }

    public void GETKEY_R_EX()
    {

        if (isConfirmingR == false && isOrtherConfirming == false)
        {
            _Curser.SetActive(true);
            if (_ATTACK.OnAttack == false)
            {
                _IsBuff(Skill_EX_IS_BUFF);
                isConfirmingR = true;
                isOrtherConfirming = true;

                print("isConfirmingR");
            }

        }
        else if (isConfirmingR == true)
        {
            if (_ATTACK.OnAttack == false)
            {
                print("EX");
                if (Skill_EX_IS_BUFF == false) { walk.TakeAction(); }

                playanime.SetTrigger("EX");
                cancer();
                gameController.closeselect();
            }
        }



    }


    public void cancer() {
        isConfirmingQ = false;
        isConfirmingW = false;
        isConfirmingE = false;
        isConfirmingR = false;
        isOrtherConfirming = false;
        _Curser.SetActive(false);
    }
    public void OnMouseDown()
    {
        print(" _touch " + transform);

        gameController.Get_touchUnits(transform);



    }

    void _IsBuff(bool _IsBufforAttack)
    {
        gameController.GmGetAttackOrBuff(_IsBufforAttack);
    }


    public void Walk()
    {
        walk.TakeAction();

    }

    public void Player_To_Ui()
    {
        _UII._getPlayer(this);
    }
    public void _IsPlay(bool isPlay)
    {
        IsPlay = isPlay;

    }


    public void ATBpaly()
    {
        ATB += Speed;


    }

    public void GetHit(float Damage)

    {
        HP -= Damage;
    }

}
