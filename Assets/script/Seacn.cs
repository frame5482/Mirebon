using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Seacn : MonoBehaviour
{
    private int levelNow;
    void Start()
    {
        levelNow = SceneManager.GetActiveScene().buildIndex;
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
         { 
        SceneManager.LoadScene(levelNow);
        }
    }
}
