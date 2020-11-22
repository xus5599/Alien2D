using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limite : MonoBehaviour
{
    public GameObject alien;
    int cont = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 5 && alien == true)
        {
            Debug.Log(" Game Over. " + " Has aguantado " + Time.time);
            Destroy(alien, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "destruible")
        {
    
            cont++;
        Debug.Log(cont);
        Destroy(collision.gameObject, 0);

        }
        if (collision.gameObject.tag == "misil")
        {
            Destroy(collision.gameObject, 0);
            Debug.Log("Misil Fallido.");
            

        }
        if (collision.gameObject.tag == "bola")
        {
            Destroy(collision.gameObject, 0);
            
            
        }
        
    }
    
}
