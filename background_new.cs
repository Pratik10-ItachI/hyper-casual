using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background_new : MonoBehaviour
{
    public Spawn Score;
    public int score,temp = 0;
    public Text text;
    [SerializeField]  GameObject background1,background2,background3;
    void Update()
    {
        score = Score.i;
        if(score <= temp + 20)
        {
             background1.SetActive(true);
             background2.SetActive(false);
             background3.SetActive(false);
              text.color = Color.black;
             
        }
        else if(score > temp +20 && score < temp + 40)
        {
            background1.SetActive(false);
            background2.SetActive(true);
            background3.SetActive(false);
             text.color = Color.black;
        }
        else if(score > temp +40 && score < temp + 60)
        {
            background1.SetActive(false);
            background2.SetActive(false);
            background3.SetActive(true);
             text.color = Color.white;
        }
        else
        {
            temp = temp +60;
        }
    }
}
