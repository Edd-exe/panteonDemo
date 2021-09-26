using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class opponentControl : MonoBehaviour
{
    NavMeshAgent nMesh;
    Animator animOppo;
    Animator animPalyer;

    public Transform h1;
    public Transform h2;
    public Transform rot1;
    public Transform hDonut1;
    public Transform hDonut2;
    public Transform hDonut3;
    public Transform hDonut4;
    public Transform h6;
    public Transform h5;
    public Transform followCube;

    public GameObject rotateScript;
    public GameObject playerBoy;
    
    public int rankingPos; 
    float Posx, Posy, Posz;
    float speed;

    bool onunde;

    void Start()
    {
        animOppo = GetComponent<Animator>();
        nMesh = GetComponent<NavMeshAgent>();
        speed = nMesh.speed;
        nMesh.destination = followCube.position;
        
        Posx = transform.position.x;
        Posx = transform.position.y;
        Posx = transform.position.z;

        
    
    }

    void Update()
    {

        if(transform.position.z > playerBoy.transform.position.z)
        {
            onunde = true;      
        }
        else
        {
            onunde = false;
        }

       
    }


     private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Respawn")
        {
            transform.position = new Vector3(Posx,Posy,Posz);
            animOppo.SetInteger("Gmovement",0);    
            nMesh.speed = speed;     
        }       
    }


    private void OnTriggerStay(Collider other) 
    {
        if (other.gameObject.name == "block1")   ////////////////////// PART 1
        {          
            if (Mathf.Abs(h1.transform.position.x - transform.position.x) < 3 )
            {
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1);
            }
            else
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0);         
            }   
        }

        if (other.gameObject.name == "block3")    
        {          
            if (Mathf.Abs(h2.transform.position.x - transform.position.x) < 3 )
            {
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1);
            }
            else
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0);         
            }   
        }
        
        
        if (other.gameObject.name == "block5") ////////////////////// PART 3
        {
            
            if (hDonut1.transform.localRotation.eulerAngles.x >= 0 && hDonut1.transform.localRotation.eulerAngles.x <= 40)
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0); 
                Debug.Log("yürü");
                
            }
            else
            {
                Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1); 
            }  
            
        }

        if (other.gameObject.name == "block4")
        {
            if (hDonut2.transform.localRotation.eulerAngles.x >= 0 && hDonut1.transform.localRotation.eulerAngles.x <= 40)
            {
                //Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1);
                
            }
            else
            {             
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0); 
                //Debug.Log("yürü");
            } 
        }

        if (other.gameObject.name == "block7") 
        {
            
            if (hDonut3.transform.localRotation.eulerAngles.x >= 0 && hDonut1.transform.localRotation.eulerAngles.x <= 40)
            {
               Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1);                
            }
            else
            {
                  
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0); 
                Debug.Log("yürü");
            }  
            
        }

        if (other.gameObject.name == "block6")
        {
            
            if (hDonut4.transform.localRotation.eulerAngles.x >= 0 && hDonut1.transform.localRotation.eulerAngles.x <= 40)
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0); 
            }
            else
            {
                Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1); 
            }  
            
        }


        if (other.gameObject.name == "block8") ////////////////////// PART 4
        {           
            if (h6.transform.position.y >= 8 )
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0);
            }            
            else
            {
                Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1); 
            }  
            
        }

        if (other.gameObject.name == "block9") 
        {           
            if (h5.transform.position.y >= 8 )
            {
                nMesh.speed = speed;
                animOppo.SetInteger("Gmovement",0);
            }            
            else
            {
                Debug.Log("dur");
                nMesh.speed = 0;
                animOppo.SetInteger("Gmovement",1); 
            }  
            
        }

        if (other.gameObject.tag == "Finish") 
        {                       
            nMesh.speed = 0;
            animOppo.SetInteger("Gmovement",1);          
           
        }

  
            
    }

    
}

//GetComponent<Collider>().enabled = true;