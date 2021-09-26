using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    float mouseX;
    public float boySpeed;
    Animator animPalyer;
    public Transform mainCamera;

    public GameObject canvasWin;
    public GameObject canvasNoWin;
    
    public int rankingPos;
    public TMPro.TextMeshProUGUI rankingtxt;


    void Start() 
    {
        animPalyer = GetComponent<Animator>();
        Cursor.visible = false;
    }
  
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mainCamera.position = new Vector3(mainCamera.transform.position.x,mainCamera.transform.position.y, transform.position.z - 16);

        if (Input.GetMouseButton(0) )
        {
           // if (transform.position.x >=-6 && transform.position.x <=6 )
           // {
                transform.Translate(mouseX * boySpeed * Time.deltaTime, 0, 10 * Time.deltaTime);
                animPalyer.SetInteger("movement",1);
            //}
            
        }
        else
        {
            animPalyer.SetInteger("movement",0);
        }
        rankingtxt.text = (rankingPos+1).ToString();
        //Debug.Log(rankingPos);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Respawn")
        {
            //Debug.Log("worked collision");
            transform.position = new Vector3(0,0,0);
            //rankingPos = ;     
        } 

        if (other.gameObject.tag == "Next")
        {
            Cursor.visible = true;
            canvasWin.SetActive(true);
            //boySpeed = 0;  
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Finish")
        {
            Cursor.visible = true;
            
            if (rankingPos == 0)
            {
                Debug.Log("winner");
                canvasWin.SetActive(true);
            }
            else
            {
                canvasNoWin.SetActive(true);
                Debug.Log("not winner");
            }
            
        }  
    }

    public void buttonNext()
    {
        SceneManager.LoadScene("Task 2");
    }



}
