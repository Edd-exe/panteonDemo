using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotates : MonoBehaviour
{
    public float xRot;
    public float yRot;
    public float zRot;

    void Update()
    {      
        transform.Rotate(xRot,yRot,zRot);            
    }
}
