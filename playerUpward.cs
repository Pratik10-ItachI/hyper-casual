using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUpward : MonoBehaviour
{
    // Start is called before the first frame update
    int follow = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(follow == 1)
        transform.Translate(0,5* Time.deltaTime,0);
       

    
       



    }
    private void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "godfather" )
        {
            follow = 2;
            //Debug.Log(follow);
        }
        if(other.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
        
    }
    
    
}
