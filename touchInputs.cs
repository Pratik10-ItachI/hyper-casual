using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchInputs : MonoBehaviour
{
    public Rigidbody2D rb;
    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch_pos.x > 0)
            {
                //rb.velocity = new Vector2(2.5f,rb.velocity.y);
            }
            else if(touch_pos.x < 0)
            {
                //rb.velocity = new Vector2(-2.5f,rb.velocity.y);
            }
        }
        else
            rb.velocity = new Vector2(0f,rb.velocity.y);
    }
}
