﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
            
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "misil")
        {
            Destroy(collision.gameObject, 0);
            Destroy(gameObject);
            Debug.Log("Bomba Fallida.");
        }
    
   

       
        if (collision.gameObject.tag == "destruible")
        {
            Destroy(collision.gameObject, 0);
            Destroy(gameObject);
 Debug.Log("Acierto.");
        }

    }
}
