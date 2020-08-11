using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over : MonoBehaviour
{
    // Start is called before the first frame update
    public Spawn a;
    int b;
    public Text Game_over_score;
    public Text high_score;
    void Update()
    {
        b = a.i;
        Game_over_score.text = b.ToString();
        high_score.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

}
