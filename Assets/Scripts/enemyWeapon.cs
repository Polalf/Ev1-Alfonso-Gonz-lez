using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeapon : MonoBehaviour
{
    public int vida;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida<=0)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player Projectile"))
        {
            vida--;
        }
    }
}
