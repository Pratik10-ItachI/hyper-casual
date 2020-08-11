using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce1 : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
   
    public int j;
    float thrust;
    
   void Update() {
     thrust = 10000f * Time.deltaTime;
      
      rigidBody.AddForce(-transform.right * thrust);
     


  }
    
    
}
  
