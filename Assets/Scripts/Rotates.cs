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

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Oppo")
        {
            other.transform.Translate(zRot *(-10) * Time.deltaTime, 0, 0);
        }

    }
}
