using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnShow : MonoBehaviour
{
    GameController gameController;



    public Image[] targetImage;
   

    public Sprite Xeno;
    public Sprite REI;
    public Sprite MONDOG;
    public Sprite Book;
    public Sprite Dragon;

    public Image targetCurrntTurn;

    public Sprite CurrntTurnXeno;
    public Sprite CurrntTurnREI;

    public GameObject[] Alltrun;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();

    }

    void Update()
    {
        Alltrun = gameController.Alltrun;
        ChangeImage(0);
        ChangeImage(1);
        ChangeImage(2);
        ChangeImage(3);
        CurrntTurn();



    }

   
    public void ChangeImage(int ImageNumber)
    {
        if (Alltrun[ImageNumber].name == "Xeno")
        {
            targetImage[ImageNumber].sprite = Xeno;
        }
       else if (Alltrun[ImageNumber].name == "REI")
        {
            targetImage[ImageNumber].sprite = REI;
        }
       else if (Alltrun[ImageNumber].name == "MONDOG")
        {
            targetImage[ImageNumber].sprite = MONDOG;
        }
        else if (Alltrun[ImageNumber].name == "Book")
        {
            targetImage[ImageNumber].sprite = Book;
        }
        else if (Alltrun[ImageNumber].name == "Dragon")
        {
            targetImage[ImageNumber].sprite = Dragon;
        }

    }

    public void CurrntTurn()
    {
        if (Alltrun[0].name == "Xeno")
        {
            targetCurrntTurn.sprite = CurrntTurnXeno;
        }
        else if (Alltrun[0].name == "REI")
        {
            targetCurrntTurn.sprite = CurrntTurnREI;
        }
      


    }
}
