using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateShooter : MonoBehaviour
{
    public GameObject rayo;
    public float tiempoParaRayo;
    float timer;
    bool canShoot;
    public float tiempoDeEspera;
    float timerEspera;
    public bool canWait;

    private void Start()
    {
        canWait = true;
    }
    private void Update()
    {
        if(canWait)
        {
            if (timer >= tiempoParaRayo)
            {
                Instantiate(rayo);
                timer = 0;
                canWait = false;
            }

            else
            {
                timer += Time.deltaTime;
            }
        }
        
        else
        {
            if(timerEspera >= tiempoDeEspera)
            {
                canWait = true;
                timerEspera = 0;
            }
            else
            {
                timerEspera += Time.deltaTime;
            }
        }
        
    }
}
