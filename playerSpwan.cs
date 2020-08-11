using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpwan : MonoBehaviour
{

    public GameObject square;
    Vector3 player;
    


    bool l;


    public int j,z;
    


    public int Generate_Random()
    {
        int j = 
        Random.Range(1, 3);
        return j;
    }
    
    

     public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "sucess_win" )
        {
            
            player = new Vector3 (Random.Range(-1.2f,1.2f),-15.5f,0f);
             j =  Generate_Random();
             
            
             
             if(j==2)
             {
                 Instantiate(square,player,Quaternion.identity);
             }
        }
        if(other.gameObject.tag == "platform" )
        {   
            other.GetComponent<Collider2D>().enabled = true;
            
             
        }
        
}}
