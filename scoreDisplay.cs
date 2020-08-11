using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour
{
    public Spawn a;
    GameObject gameObject;
    int b;
    public Text TextScore;
     void Start()
    {
        gameObject = GameObject.Find("Main Controls");
        a = gameObject.GetComponent<Spawn>();
    }

    void Update()
    {   

        b = a.i;
        TextScore.text = b.ToString();
    }
   
}
