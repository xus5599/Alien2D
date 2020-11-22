using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misil : MonoBehaviour
{
    public float velocidad = 8.0f;
    int misilesfallidos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vX = velocidad * Time.deltaTime;
        transform.Translate(vX, 0, 0);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "bomba")
        {
            Destroy(collision.gameObject, 0);
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag == "destruible")
        {
            Destroy(collision.gameObject, 0);
            Destroy(gameObject);
            
        }

    }


}
