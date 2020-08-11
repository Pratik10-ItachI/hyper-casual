using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    int  spawn_no,x;
    
  
    public GameObject square1;
    bool once = true;
    
  
  
    public GameObject[] gameObjects;
    private Animator[] animator;
    public int i = 0;

     
    public int Generate_Random()
    {
        int j = 
        Random.Range(0, 16);
        return j;
    }
    private void Start() {
        animator = new Animator[gameObjects.Length];
        for(int z = 0 ;z<16;z++)
        {
            animator[z] = gameObjects[z].GetComponent<Animator>();
        }
        
  
        
        

    }
      

   
    void Update()
    {   
   
       
        if(once == true)
        {
               spawn_no = Generate_Random();
               
         gameObjects[spawn_no].SetActive(true);
         square1 = gameObjects[spawn_no];
        once = false;
        }
            

        if(square1.transform.position.y >= 7)
        {
             spawn_no = Generate_Random();
         gameObjects[spawn_no].SetActive(true);
         square1 =  gameObjects[spawn_no];
         if(i<=120)
         animator[spawn_no].speed = 1.5f + i/55;
         else
         animator[spawn_no].speed = 3.2f;

        }
       


    }
    public void Score()
    {
        i++;   
    } 
}
