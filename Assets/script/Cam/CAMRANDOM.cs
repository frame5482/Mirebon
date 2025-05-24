using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMRANDOM : MonoBehaviour
{
    Vector3 cameraInitialPosition;
    public float shakeMagnitude = 0.05f, shakeTime = 0.5f;
    public Camera mainCamera;

    bool keyQ = true;
    
     void Start()
    {
       
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)&& keyQ ==  true)
        {
            ShakeIt();
            keyQ = false;
        }



    }
    public void ShakeIt()
    {
        mainCamera.enabled = true;
        print("StartCamerashaking");
        cameraInitialPosition = mainCamera.transform.position;
        InvokeRepeating("StartCamerashaking", 0f, 0.005f);
        Invoke("StopCamerashaking", shakeTime);
        print("StopCamerashaking");

    }
    public void StartCamerashaking()
    {

        
        float camerashakingoffsetX = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        float cameraShakingoffsety = Random.value * shakeMagnitude * 2 - shakeMagnitude;
        Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
        cameraIntermadiatePosition.x += camerashakingoffsetX;
        cameraIntermadiatePosition.y += cameraShakingoffsety;
        mainCamera.transform.position = cameraIntermadiatePosition;
    }
    public void StopCamerashaking()
    {
        CancelInvoke("StartCamerashaking");
        mainCamera.transform.position = cameraInitialPosition;
        keyQ = true;
        mainCamera.enabled = false;
    }
}
