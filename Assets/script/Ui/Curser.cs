using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour
{
    public Transform targetEnemy; 
    public Transform arrowUI; 

    


    public float UpPosition = 2f ;
    private void Start()
    {
        StartCoroutine(W8curcer());
    }
    void Update()
    {
 

        if (targetEnemy != null)
        {
            print("Cuser");
            Vector3 _targetEnemy = targetEnemy.position;
            arrowUI.position = _targetEnemy + new Vector3(0, UpPosition, 0);
        }

    }

    
    public void SetNewTarget(Transform newTarget)
    {
        targetEnemy = newTarget;
        print("newTarget");
    }

    IEnumerator W8curcer()
    {
      yield  return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }

}
