using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{

    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject Monster;

   

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangedCam();
        }
       
    }


   
    public void ChangedCam()
    {
        Player.SetActive(false);
        Monster.SetActive(true);
        StartCoroutine(DelayChangedcam(2));

    }


    IEnumerator DelayChangedcam(float w8)
    {

        yield return new WaitForSeconds(w8);
        Monster.SetActive(false);
        Player.SetActive(true);
        

    }

}
