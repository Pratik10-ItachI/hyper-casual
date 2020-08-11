using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubblesprite : MonoBehaviour
{
     [SerializeField] BubbleLives Life;
      int a;
      public Sprite life,current;
     
    public SpriteRenderer spriteRenderer,spriteRenderer1,spriteRenderer2;
    void Update()
    {
         a = Life.lives;
         if(a==0)
         {
             spriteRenderer.sprite = current;
             spriteRenderer1.sprite = current;
             spriteRenderer2.sprite = current;
         }
         if(a==1)
         {
             spriteRenderer.sprite = life;
             spriteRenderer1.sprite = current;
             spriteRenderer2.sprite = current;
         }
          if(a==2)
         {
             spriteRenderer.sprite = life;
             spriteRenderer1.sprite = life;
             spriteRenderer2.sprite = current;
         }
          if(a==3)
         {
             spriteRenderer.sprite = life;
             spriteRenderer1.sprite = life;
             spriteRenderer2.sprite = life;
         }


    }
}
