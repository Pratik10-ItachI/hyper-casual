using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableGameobject : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }
       public int Generate_Random()
    {
        int j = 
        Random.Range(1, 3);
        return j;
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(transform.position.y >= 7)
        {   

            gameObject.SetActive(false) ;
            this.transform.GetChild(0).GetComponent<Collider2D>().enabled = true;
            this.transform.GetChild(1).GetComponent<Collider2D>().enabled = true;
            
        }
       
    }
}
