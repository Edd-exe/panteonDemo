using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallPaint : MonoBehaviour
{
    bool clickFirst = true;
    RaycastHit carpma;
    float painted;
    float maxpaint = 49;

    public Slider paintSlider;

    void Update()
    {      
        paintSlider.value = painted; 

        Ray outray = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(outray.origin,outray.direction *50f , Color.red);
            
        if (Physics.Raycast(outray, out carpma) && Input.GetMouseButton(0))
        {
            if (carpma.collider.gameObject.tag == "unpainted")
            {
                Debug.Log("mouse click");
                clickFirst = false;
                carpma.collider.gameObject.tag = "painted";
                painted +=1;
                Debug.Log(painted);
            }
        }

        if (painted == 49)
        {
            Debug.Log("Winnn 2 !!");
        }   
    }    

    /*void  OnMouseDown() 
    {
    }*/

}
