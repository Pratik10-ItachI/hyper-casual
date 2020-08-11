using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balconySpawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject b1,b2,b3,b4;
    int a,b,c,d,z,x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        
    }
    public void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "w")
        {   
            
             a = Random.Range(0,3);
             b = Random.Range(3,6);
            b2.transform.GetChild(a).GetComponent<SpriteRenderer>().enabled = true;
            b2.transform.GetChild(b).GetComponent<SpriteRenderer>().enabled = true;
            b3.transform.GetChild(c).GetComponent<SpriteRenderer>().enabled = false;
            b3.transform.GetChild(d).GetComponent<SpriteRenderer>().enabled = false;
            
        }
        if(other.gameObject.tag == "e")
        {   
            
             c = Random.Range(0,3);
             d = Random.Range(3,6);
            b3.transform.GetChild(c).GetComponent<SpriteRenderer>().enabled = true;
            b3.transform.GetChild(d).GetComponent<SpriteRenderer>().enabled = true;
            b1.transform.GetChild(z).GetComponent<SpriteRenderer>().enabled = false;
            b1.transform.GetChild(x).GetComponent<SpriteRenderer>().enabled = false;  
           
        }
         if(other.gameObject.tag == "r")
        {   
              z = Random.Range(0,3);
             x = Random.Range(3,6);

            b1.transform.GetChild(z).GetComponent<SpriteRenderer>().enabled = true;
            b1.transform.GetChild(x).GetComponent<SpriteRenderer>().enabled = true;  
            b2.transform.GetChild(a).GetComponent<SpriteRenderer>().enabled = false;
            b2.transform.GetChild(b).GetComponent<SpriteRenderer>().enabled = false;  
        }
        }

    }


