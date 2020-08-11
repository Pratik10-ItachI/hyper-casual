using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AddPlayer : MonoBehaviour
{
    public Transform Player,a;
    
    public int i = 0, k = 0,temp;
    private GameObject clone;
    Vector3 newPos ;
    
    void Start()
    {   
        a = Player;
    }

    void FixedUpdate()
    {
        i = transform.childCount;
        if(i==0)
        {
            SceneManager.LoadScene(0);
            Player = GameObject.Find("Main Controls").transform;
        }
        else
        {
            Player = transform.GetChild(0).transform;
            a=transform.GetChild(i-1).transform;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player" )
        {       
                
            newPos = new Vector3(a.position.x + .7f,a.position.y,a.position.z);
            if(i==1)
            {   
                
                other.transform.position = newPos;  
                other.transform.parent = GameObject.Find("Main Controls").transform;
            }
            else if(i==2)
            {
                other.transform.position = newPos;  
                other.transform.parent = GameObject.Find("Main Controls").transform;
            }
            else if(i==3)
            {
                other.transform.position = newPos;  
                other.transform.parent = GameObject.Find("Main Controls").transform;
        
            }
            else if(i==4)
            {
                other.transform.position = newPos;  
                other.transform.parent = GameObject.Find("Main Controls").transform;
            }
            else if(i==5)
            {
                return;
            }
        }
    }
 }
        
    