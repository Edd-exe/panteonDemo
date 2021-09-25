using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfDonut : MonoBehaviour
{   
    public int HDPos;
    public float speed;
    int a;



    void Update()
    { 
        if (HDPos == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(a,0,0), speed * Time.deltaTime);

            if ( transform.localRotation.eulerAngles.x <= 1)
            {
                a = 90;
            }   
            if ( transform.localRotation.eulerAngles.x >= 89)
            {
                a = 0;
            }
        }

        if (HDPos == 1)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(a,0,180), speed * Time.deltaTime);

            if ( transform.localRotation.eulerAngles.x <= 1)
            {
                a = 90;
            }   
            if ( transform.localRotation.eulerAngles.x >= 89)
            {
                a = 0;
            }
        }
 
       //   Debug.Log(transform.localRotation.eulerAngles.x);

    }

}

// transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(0,0,0), speed * Time.deltaTime);
// StartCoroutine(rotateTimer());
// Mathf.Abs()
// transform.localRotation.eulerAngles.x
// transform.Rotate(0,0,0);