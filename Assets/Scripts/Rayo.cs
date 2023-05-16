using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo : MonoBehaviour
{
    
    public float autoDestroy;

    private void Start()
    {
        Destroy(gameObject, autoDestroy);
    }

    
}
