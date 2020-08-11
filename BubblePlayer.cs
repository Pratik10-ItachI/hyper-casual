using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject L1,L2,L3;
    [SerializeField] BubbleLives Life;
    public Sprite life,current;
     
    public SpriteRenderer spriteRenderer,spriteRenderer1;
    
    int a;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = Life.lives;
        
            if(a == 1)
            {   
                
                L1.SetActive(true);
                L2.SetActive(false);
                L3.SetActive(false);
                

            }
            if(a == 2)
            {
                L1.SetActive(false);
                L2.SetActive(true);
                L3.SetActive(false);
            }
            if(a == 3)
            {   
                 L1.SetActive(false);
                L2.SetActive(false);
                L3.SetActive(true);
            }
         
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {   
            Life.AddLife(); 
           
             Destroy(other.gameObject);
        }
    }
}
