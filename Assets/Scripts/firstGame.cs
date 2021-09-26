using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstGame : MonoBehaviour
{
    public GameObject canvasFirst;
    
    void Update()
    {
        if (Input.GetMouseButton(0) )
        {
            canvasFirst.SetActive(false);
        }
    }
}
