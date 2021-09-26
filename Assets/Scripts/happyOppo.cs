using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happyOppo : MonoBehaviour
{
    Animator animHappie;
    public int a;

    void Start()
    {
        animHappie = GetComponent<Animator>();
        a = Random.Range(0,4);
    }

    void Update()
    {
        animHappie.SetInteger("happie",a);
    }
}
