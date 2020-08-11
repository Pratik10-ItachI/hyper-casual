using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindForce : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    
   
    public int j;
    float thrust ;
  public void Update() {
          thrust = 10000 * Time.deltaTime;
      rigidBody.AddForce(  transform.right * thrust);
      
      


  }
    
    
}
  
