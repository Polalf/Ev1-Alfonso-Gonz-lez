using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreShooter : MonoBehaviour
{
    public GameObject Bullet;

    public float tiempoDisparoMax, tiempoDisparoMin;
    float temporizador;
    float timer;
    bool canShoot;

    
    void Update()
    {
        if(timer>= temporizador)
        {
            canShoot = true;
        }
        else
        {
            timer += Time.deltaTime;
        }
        if(canShoot)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            timer = 0;
            canShoot=false;
            temporizador = Random.Range(tiempoDisparoMin, tiempoDisparoMax);
        }
    }
}
