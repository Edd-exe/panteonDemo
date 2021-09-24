using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfDonut : MonoBehaviour
{   
    public float speed;
    public float cooldown;
    void Start()
    {
        StartCoroutine(rotateTimer());
    }

    void Update()
    {
       
    }

    public IEnumerator rotateTimer()
    {
        while (true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation,  Quaternion.Euler(90,0,0), speed * Time.deltaTime);
            yield return new WaitForSeconds(cooldown); 
        }
        
    }
}
