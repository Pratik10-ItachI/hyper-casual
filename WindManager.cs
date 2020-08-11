using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    [SerializeField] GameObject WR, WL;
    [SerializeField] Spawn score;

    public int A;
    [SerializeField] int a = 1, b=0, c=5, d = 1, e = 10;
    private void Start()
    {

    }
    public int Generate_Random()
    {
        int j = Random.Range(b, c);
        return j;
    }
    void Update()
    {
        A = score.i;
        if(A==0)
        {
            return;
        }
        if (A == 5 * d)
        {
            d++;
            e = Generate_Random();
            e += 5;
            b = c;
            c += 5;
            Debug.Log(e);
        }
        else if (e == A)
        {
            //Debug.Log(b);
           // Debug.Log(c);
            WR.SetActive(true);
            /*if(a%2==0)
            {
                if(!WL.active)
                {
                    WR.SetActive(true);
                    a++;
                }
            }
            else
            {
                if(!WR.active)
                {
                    WL.SetActive(true);
                    a++;
                }
            }

            }
            else
            {
                WR.SetActive(false);
                WL.SetActive(false);
            }*/
        }
        else
        {
            WR.SetActive(false);
            WL.SetActive(false);
        }
    }
}
