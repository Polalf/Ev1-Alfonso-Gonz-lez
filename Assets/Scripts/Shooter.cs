using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Proyectile;
    
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
           Instantiate(Proyectile, transform.position, transform.rotation);
           
        }
    }
}

