using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public GameObject bomba;
    float timeAux;

    // Start is called before the first frame update
    void Start()
    {
        timeAux = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timeDif = Time.time - timeAux;

        if (Input.GetKeyDown(KeyCode.Space) && timeDif > 1f)
        {
            
            Vector3 pos = new Vector3(transform.position.x , transform.position.y , 0);
            GameObject clone = Instantiate(bomba, pos, Quaternion.identity) as GameObject;
            clone.SetActive(true);

            Vector3 direccion = new Vector3(-600, 500, 0);

            Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
            rb.AddForce(direccion);


            timeAux = Time.time;

        }
    }
   
}
