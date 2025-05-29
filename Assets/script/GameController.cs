using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class GameController : MonoBehaviour
{

    public int Current_Trun;


    public List<Units> allUnits = new List<Units>();
    public List<MON> Allmon = new List<MON>();

    public GameObject[] Alltrun;

    public Transform GMCurrent_select;
    public int select_Index = 0;
    public int List_Length;
    public bool GMIsAttackOrBuff;
    public Curser _Curser;

    public GameObject[] Selectplayer;
    public GameObject[] SelectMon;


    public bool _closeselect = false;

    void Start()
    {
       
        _Curser = FindObjectOfType<Curser>();

        

       // _Turn();
    }

    // Update is called once per frame
    void Update()
    {


        allUnits = FindObjectsOfType<Units>().ToList();
        Allmon = FindObjectsOfType<MON>().ToList();

        var combinedList = allUnits.Cast<object>()
                                   .Concat(Allmon)
                                   .OrderByDescending(obj => (obj is Units unit) ? unit.ATB : ((MON)obj).ATB)
                                   .Select(obj => (obj is Units unit) ? unit.gameObject : ((MON)obj).gameObject)
                                   .ToList();
        Alltrun = combinedList.ToArray();
        playTrunATB();
        select();
        Findselect();
        if (Current_Trun >= Alltrun.Length)
        {
            Current_Trun = 0;
          //  _Turn();
        }
        if (_closeselect == true)
        {
            closeselect();
        }
        else if (_closeselect == false)
        {
            ISBuffGM();
        }
     





    }
   
    public void Findselect()
    {
        
        Transform[] allObjects = FindObjectsOfType<Transform>(true); 

       
        Selectplayer = allObjects
            .Where(obj => obj.name.StartsWith("SelectPlayer"))
            .Select(obj => obj.gameObject)
            .ToArray();

        SelectMon = allObjects
            .Where(obj => obj.name.StartsWith("SelectMon"))
            .Select(obj => obj.gameObject)
            .ToArray();
    }

   /* public void _Turn()
    {
        GameObject _Alltrun = Alltrun[Current_Trun];

        Units currentUnit = _Alltrun.GetComponent<Units>();
        MON currentMon = _Alltrun.GetComponent<MON>();

        if (currentUnit != null)
        {
            print("‡∑‘√Ïπ¢Õß: " + currentUnit.name);
            currentUnit._IsPlay(true);
        }
        else if (currentMon != null)
        {
            print("‡∑‘√Ïπ¢Õß: " + currentMon.name);
            currentMon._IsPlayMON(true);
        }


    }*/

    public void ATBPlus()
    {
        GameObject _Alltrun = Alltrun[Current_Trun];

        Units currentUnit = _Alltrun.GetComponent<Units>();
        MON currentMon = _Alltrun.GetComponent<MON>();

        currentUnit.ATBpaly();
        currentMon.ATBpaly();


    }

    public void playTrunATB()
    {
        GameObject _Alltrun = Alltrun[0];

        Units currentUnit = _Alltrun.GetComponent<Units>();
        MON currentMon = _Alltrun.GetComponent<MON>();

        if (currentUnit != null)
        {
            print("‡∑‘√Ïπ¢Õß: " + currentUnit.name);
            currentUnit._IsPlay(true);

        }
        else if (currentMon != null)
        {
            print("‡∑‘√Ïπ¢Õß: " + currentMon.name);
            currentMon._IsPlayMON(true);
        }
     
    }


    public void NextTurn()
    {
        Current_Trun = (Current_Trun + 1);

        foreach (Units _allUnits in allUnits)
        {
            print("Units");
            _allUnits.ATBpaly();

        }

        foreach (MON _ALLMon in Allmon)
        {
            print("_ALLMon");
            _ALLMon.ATBpaly();

        }
      
    }




    void select()
    { if (Input.GetKeyDown(KeyCode.A))
        {
         
            select_Index -= 1;
           
            if (select_Index < 0)
            {
                select_Index = List_Length;
                
            }
            ISBuffGM();

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            select_Index += 1;
           
            if (select_Index > List_Length)
            {
                select_Index = 0;
                

            }
            ISBuffGM();

        }
    }
   public void ISBuffGM()
    {
        if (GMIsAttackOrBuff == true)
        {
            
            GMCurrent_select = allUnits[select_Index].transform;
            List_Length = allUnits.Count - 1;
            _Curser.SetNewTarget(allUnits[select_Index].transform);
         

            foreach (GameObject player in Selectplayer)
            {
                if (player != null)
                {
                    player.SetActive(true);
                }
            }
            foreach (GameObject mon in SelectMon)
            {
                if (mon != null)
                {
                    mon.SetActive(false);
                }
            }


        }
        else if (GMIsAttackOrBuff == false)
        {
            
            GMCurrent_select = Allmon[select_Index].transform;
            List_Length = Allmon.Count - 1;
            _Curser.SetNewTarget(Allmon[select_Index].transform);
            foreach (GameObject player in Selectplayer)
            {
                if (player != null)
                {
                    player.SetActive(false);
                }
            }
            foreach (GameObject mon in SelectMon)
            {
                if (mon != null)
                {
                    mon.SetActive(true);
                }
            }

        }
       
    }
   public void GmGetAttackOrBuff(bool GmGetAttackOrBuff)
    {
        GMIsAttackOrBuff = GmGetAttackOrBuff;
        return;
    }

    public void Get_touchUnits(Transform Get_touchposition)
    {
        if (GMIsAttackOrBuff == true)
        {

            print(" Get_touchposition ");
            GMCurrent_select = Get_touchposition;
            _Curser.SetNewTarget(GMCurrent_select.transform);
        }
      


    }
    public void Get_touchEnemy(Transform Get_touchposition)
    {
      
        if (GMIsAttackOrBuff == false)
        {

            print(" Get_touchposition ");
            GMCurrent_select = Get_touchposition;
            _Curser.SetNewTarget(GMCurrent_select.transform);
        }


    }

    public void closeselect()
    {
        foreach (GameObject player in Selectplayer)
        {
            if (player != null)
            {
                player.SetActive(false);
            }
        }
        foreach (GameObject mon in SelectMon)
        {
            if (mon != null)
            {
                mon.SetActive(false);
            }
        }
    }

    public void closeselectTrueOrfalse(bool __closeselect)
    {
        _closeselect = __closeselect;
    }

}

