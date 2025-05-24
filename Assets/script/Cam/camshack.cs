using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camshack : MonoBehaviour
{
    public float damptimp = 0.5f;
    public Vector3 velocity = Vector2.zero;
    public Transform TargetCameraPlayer;
    Camera CameraPlayer;
     void Start()
    {
        CameraPlayer = GetComponent<Camera>();

    }

    void Update()
    {
        if (TargetCameraPlayer)
        {
            Vector3 point = CameraPlayer.WorldToViewportPoint(TargetCameraPlayer.position);
            Vector3 delta = TargetCameraPlayer.position - CameraPlayer.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, damptimp);
        }

    }
}
