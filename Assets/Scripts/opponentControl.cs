using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class opponentControl : MonoBehaviour
{
    public Transform followCube;
    Animator animPalyer;

    void Start()
    {
        NavMeshAgent nMesh = GetComponent<NavMeshAgent>();
        nMesh.destination = followCube.position;
        

    }

    void Update()
    {
        //animPalyer.SetInteger("movement",1);
    }
}
