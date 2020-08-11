using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public AddPlayer ChildCount;
    public int child;
    void FixedUpdate()
    {
        child = ChildCount.i;

        if(child==1)
         this.transform.GetChild(0).GetComponent<Animator>().SetInteger("childcount",child);
        
        else if(child==2)
        {   

            this.transform.GetChild(0).GetComponent<Animator>().SetInteger("childcount",child);
            this.transform.GetChild(1).GetComponent<Animator>().SetInteger("childcount",child+1);
            
            
        }
        else if(child==3)
        {   

            this.transform.GetChild(0).GetComponent<Animator>().SetInteger("childcount",child+1);
            this.transform.GetChild(1).GetComponent<Animator>().SetInteger("childcount",child+2);
            this.transform.GetChild(2).GetComponent<Animator>().SetInteger("childcount",child+3);
            
            
        }
        else if(child==4)
        {   

            this.transform.GetChild(0).GetComponent<Animator>().SetInteger("childcount",child+3);
            this.transform.GetChild(1).GetComponent<Animator>().SetInteger("childcount",child+4);
            this.transform.GetChild(2).GetComponent<Animator>().SetInteger("childcount",child+5);
            this.transform.GetChild(3).GetComponent<Animator>().SetInteger("childcount",child+6);
            
            
        }
        else if(child==5)
        {   

            this.transform.GetChild(0).GetComponent<Animator>().SetInteger("childcount",child+6);
            this.transform.GetChild(1).GetComponent<Animator>().SetInteger("childcount",child+7);
            this.transform.GetChild(2).GetComponent<Animator>().SetInteger("childcount",child+8);
            this.transform.GetChild(3).GetComponent<Animator>().SetInteger("childcount",child+9);
            this.transform.GetChild(4).GetComponent<Animator>().SetInteger("childcount",child+10);
        }
    }
}
