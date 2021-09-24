using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorObstacle : MonoBehaviour
{
    int a = 1;
    public float speed;
    public GameObject HorObj;
    public float maxPos = 6;
    public float minPos = -6;

    void Update()
    {
        transform.Translate(speed* a* Time.deltaTime, 0, 0);
        
        if (transform.position.x <= minPos)
        {
            a = 1; 
        }
        
        if (transform.position.x >= maxPos)
        {
            a=-1;
        }

        HorObj.transform.Rotate(0,speed/5,0);
    }
}
