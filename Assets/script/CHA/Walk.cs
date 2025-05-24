using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public Transform enemyTarget; 
    private Vector3 startPos; 
    public float moveSpeed = 5f;

   public GameController _GetenemyTarget ;

    public float HOWRANG = -2.5f;

    void Start()
    {
        startPos = transform.position;
        _GetenemyTarget = FindObjectOfType<GameController>();
    }
    private void Update()
    {
        GetenemyTarget(_GetenemyTarget);
    }
    public void GetenemyTarget(GameController _GetenemyTarget)
    {
        print("NEWTARGETTransform");
        enemyTarget = _GetenemyTarget.GMCurrent_select;
    }

    public void TakeAction()
    {
         StartCoroutine(MoveToTarget(enemyTarget.position + new Vector3(HOWRANG, 0, 0)));
       
    }

    public void Retrun()
    {
        print("Retrun");
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

  
}
