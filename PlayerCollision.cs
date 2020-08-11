using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int i =0; 
    Spawn score;
    BubbleLives life;
    private void Start() {
        score = FindObjectOfType<Spawn>();
        life = FindObjectOfType<BubbleLives>();
    }
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "platform")
        {   
            
            life.MinusLife();
            other.GetComponent<Collider2D>().enabled = false;

        } 
        
        if(other.gameObject.tag == "sucess_win")
        {   
            score.Score();
        } 
    

    }
   
}
