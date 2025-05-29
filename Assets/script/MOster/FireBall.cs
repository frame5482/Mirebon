using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Transform Target;


    public List<Units> _Units = new List<Units>();
    private Vector3 startPos;

    public int ATK = 300;
    public float moveSpeed = 20f;
    public int INDEX_TO_RANDOM;
    public int INDEX_TO_ATTACK;

    void Start()
    {
        startPos = transform.position;
        _Units = FindObjectsOfType<Units>().ToList();
        Rendom();
        TakeAction();
    }

  
    void Update()
    {
        
    }
    public void Rendom()
    {
        INDEX_TO_RANDOM = _Units.Count;
        INDEX_TO_ATTACK = UnityEngine.Random.Range(0, INDEX_TO_RANDOM);

        Target = _Units[INDEX_TO_ATTACK].transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {


            foreach (Units _Units in _Units)
            {
                print(_Units.name);
                _Units.GetHit(ATK);
            }
            Destroy(this.gameObject);
        }
    }

    public void TakeAction()
    {
        StartCoroutine(MoveToTarget(Target.position + new Vector3(0, 0, 0)));

    }

    public void Retrun()
    {
        StartCoroutine(MoveToTarget(startPos));
    }

    IEnumerator MoveToTarget(Vector3 target)
    {
        float time = 0;
        Vector3 start = transform.position;

        while (time < 1f)
        {
            time += Time.deltaTime * moveSpeed;
            transform.position = Vector3.Lerp(start, target, time);
            yield return null;
        }
    }


    public void GetTarget(Transform GetTarget)
    {
        Target = GetTarget;
    }
}
