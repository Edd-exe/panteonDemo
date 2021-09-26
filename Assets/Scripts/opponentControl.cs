using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class opponentControl : MonoBehaviour
{
    public Transform followCube;
    Animator animPalyer;
    float Posx, Posy, Posz;
    NavMeshAgent nMesh;
    Animator animOppo;

    public Transform h1;
    public Transform h2;
    public Transform rot1;
    
    float speed;


    void Start()
    {
        animOppo = GetComponent<Animator>();

        nMesh = GetComponent<NavMeshAgent>();
        Debug.Log(nMesh.speed);
        speed = nMesh.speed;
        nMesh.destination = followCube.position;
        
        Posx = transform.position.x;
        Posx = transform.position.y;
        Posx = transform.position.z;
    }

    void Update()
    {
        

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
        if (other.gameObject.name == "block1")
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

        if (other.gameObject.name == "block11")
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

        if (other.gameObject.name == "Cylinder")
        {
           
            
        }  
        
        
            
    }

    
}

//GetComponent<Collider>().enabled = true;