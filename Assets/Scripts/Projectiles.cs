using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;
    public float autoDestroy;

    private void Start()
    {
        Destroy(gameObject,autoDestroy);
    }

    void Update()
    {
        transform.position += Vector3.up *speed * Time.deltaTime;

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
