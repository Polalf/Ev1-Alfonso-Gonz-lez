using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject torr1,torr2,amet1,amet2,sate;
    bool torr1Des,torr2De,amet1Des,amet2Des,sateDes;
    private void Start()
    {
        torr1Des = false;
        torr2De = false;
        amet1Des = false;
        amet2Des = false;
        sateDes = false;
    }

    void Update()
    {
        if(torr1== false)
        {
            torr1Des =true;

        }

        if (torr2 == false)
        {
            torr2De = true;

        }

        if (amet1 == false)
        {
            amet1Des = true;

        }

        if (amet2 == false)
        {
            amet2Des = true;

        }
        if (sate == false)
        {
            sateDes = true;


        }

        if (torr1Des && torr2De && amet1Des && amet2Des && sateDes)
        {
            Destroy(gameObject);
            Debug.Log("Has Ganado");
        }
    }
}
