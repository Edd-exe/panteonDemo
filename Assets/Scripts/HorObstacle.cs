using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorObstacle : MonoBehaviour
{
    int a = 1;
    public float speed;
    public GameObject HorObj;
    public float maxPos;
    public float minPos;
    public int vectorPos;

    void Update()
    {
        transform.Translate(speed* a* Time.deltaTime, 0, 0);
        
        if ( vectorPos == 0) // x 
        {
            if (transform.position.x <= minPos)
            {
                a = 1; 
            }
        
            if (transform.position.x >= maxPos)
            {
                a=-1;
            }        
        }

        if ( vectorPos == 1) // y 
        {
            if (transform.position.y <= minPos)
            {
                a = 1; 
            }
        
            if (transform.position.y >= maxPos)
            {
                a=-1;
            }        
        }
        

        HorObj.transform.Rotate(0,speed/5,0);
    }


}
