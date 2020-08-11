using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLives : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives = 1;
    [SerializeField] GameObject Gameover_panel;
    public Spawn a;
    int b;
    void Update()
    {
        
    }
    public void AddLife()
    {   
        if(lives >= 3)
        lives = 3;
        else if(lives >=1 && lives <3)
        lives++;
    }
    public void MinusLife()
    {
        if(lives < 1)
        lives = 1;
        else if(lives >=1 && lives <=3)
        lives--;
        if(lives == 0)
        {
            Gameover_panel.SetActive(true);
            Time.timeScale = 0f;
            b = a.i;
            if (PlayerPrefs.GetInt("Highscore") < b)
            {
                PlayerPrefs.SetInt("Highscore", b);
            }
        }
    }

}
