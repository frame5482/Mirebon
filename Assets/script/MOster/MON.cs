using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MON : MonoBehaviour
{

    public float MaxHP = 1000;
    public float HP = 1000;
    public float ATK = 300;
    public float Defense = 60;
    public float LIFESTEAL = 5;
    public float Crit_Rate = 10;
    public float Crit_DMG = 50;
    public float Weakness_Reveal = 10;
    public float Exploit_DMG = 70;


    public float Speed = 60;
    public float MaxATB = 100;
    public float ATB = 50;


    public bool IsPlay = false;
    public bool IsRANDOM = false;

    GameController gameController ;

    public List<Units> units  = new List<Units>();
    public Transform _TargetWalkMONster;

    public WalkMONster _Walk;

    public int INDEX_TO_RANDOM;
    public int INDEX_TO_ATTACK;
     

    public bool isActing = false;



    public FlashOnHit flashOnHit;


    [SerializeField]
    Transform HpbarPlayer;


    private Vector3 initialScale;


    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        units = FindObjectsOfType<Units>().ToList();

        initialScale = HpbarPlayer.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlay == true && isActing == false )
        {
           
            StartCoroutine(w8(1));

        }

        Update_HPbar(HP);
        if (HP == 0)
        {
            Destroy(gameObject);
        }
    }
    void Update_HPbar(float hp)
    {
        HP = Mathf.Clamp(hp, 0, MaxHP);
        float ratio = HP / MaxHP;


        HpbarPlayer.localScale = new Vector3(initialScale.x * ratio, initialScale.y, initialScale.z);

    }
    IEnumerator w8(int _W8 )
    {
        isActing = true;

        yield return new WaitForSeconds(1);

        Rendom();

        _Walk.TakeAction();

        yield return new WaitForSeconds(1);
        Attack();
        _Walk.Retrun();
      
        gameController.NextTurn();
        ATB = 0;
        IsPlay = false;
        isActing = false;

        // gameController._Turn();

    }
    public void Rendom()
    {
        INDEX_TO_RANDOM = units.Count;
        INDEX_TO_ATTACK = UnityEngine.Random.Range(0, INDEX_TO_RANDOM);

        _TargetWalkMONster = units[INDEX_TO_ATTACK].transform;
        _Walk.GetenemyTarget(_TargetWalkMONster);
    }
    public void _IsPlayMON(bool isPlay)
    {
        if (IsPlay == isPlay) return;
        IsPlay = isPlay;
       
    }


    public void UpdateMonsterHp(float MON_GETDAMAG)
    {
        flashOnHit.Flash();
        HP = HP- MON_GETDAMAG;
        print("Monster-Hp" + gameObject.name);
    }
    public void OnMouseDown()
    {
        print(" _touch " + transform);

        gameController.Get_touchEnemy(transform);



    }


    public void ATBpaly()
    {
        ATB += Speed;


    }

    public void Attack()
    {

        units[INDEX_TO_ATTACK].GetHit(ATK);
    }

}
