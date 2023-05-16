using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ametShooter : MonoBehaviour
{
    public GameObject ameBullet;
    
    public float tiempoDisparo;
    float timer;
    bool canShoot;
    
    bool disparando;
    //DELAY//
    public float delay;
    float timerDelay;
    bool canDelay;

    void Update()
    {
        if(timer >= tiempoDisparo)
        {
            canShoot = !canShoot;
            timer =  0;

        }
        else
        {
            timer +=Time.deltaTime;
        }

        if(canShoot)
        {
           
            Rafaga();
        }
        
    }
    void Rafaga()
    {
        
        if(timerDelay >= delay)
        {
            canDelay= true;
           
        }
        else
        {
            timerDelay+=Time.deltaTime;
            canDelay = false;
        }
        if(canDelay)
        {
            Instantiate(ameBullet, transform.position, transform.rotation);
            timerDelay = 0;
            canDelay= false;
        }
        
    }
    
}
