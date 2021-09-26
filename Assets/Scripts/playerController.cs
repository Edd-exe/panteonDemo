using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    float mouseX;
    public float boySpeed;
    Animator animPalyer;
    public Transform mainCamera;

    public bool[] rankingControl;

    void Start() 
    {
        animPalyer = GetComponent<Animator>();
    }
  
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mainCamera.position = new Vector3(mainCamera.transform.position.x,mainCamera.transform.position.y, transform.position.z - 16);

        if (Input.GetMouseButton(0))
        {
            transform.Translate(mouseX * boySpeed * Time.deltaTime, 0, 10 * Time.deltaTime);
            animPalyer.SetInteger("movement",1);
        }
        else
        {
            animPalyer.SetInteger("movement",0);
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Respawn")
        {
            Debug.Log("worked collision");
            transform.position = new Vector3(0,0,0);     
        } 

        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("win!!");
        }   
    }



}
