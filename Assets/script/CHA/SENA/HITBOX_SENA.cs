using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HITBOX_SENA : MonoBehaviour
{

    public float DMG = 100;
    public List<MON> _MON = new List<MON> ();

    public ATTACK _SENA ;
    public Transform _MONName;
    public GameController _gameController;


    public MON _MONSOLO;

    public bool IsAOE = false;
    private void Start()
    {
        _MON = FindObjectsOfType<MON>().ToList();
        _gameController = FindObjectOfType<GameController> ();

       
    }

    public void Update()
    {
       
        _MONNameATTACK(_gameController);
        _MONSOLO = GameObject.Find(_MONName.name)?.GetComponent<MON>();
    }
    public void ATTACK_DMG(float GET_DMG)
    {
        DMG = GET_DMG;
        
    }

    public void _MONNameATTACK(GameController GET_MONName)
    {
        _MONName = GET_MONName.GMCurrent_select;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (_SENA.OnDMG == true)
        {
            if (collision.gameObject.CompareTag("Monster") && IsAOE == false)
            {

                
                    print(_MONName.name);
                    _MONSOLO.UpdateMonsterHp(DMG);
                
            }


            else if (collision.gameObject.CompareTag("Monster") && IsAOE == true)
            {


                foreach (MON mon in _MON)
                {
                    print("Monster");
                    mon.UpdateMonsterHp(DMG);
                }

            }
        }

     
    }

    

}

