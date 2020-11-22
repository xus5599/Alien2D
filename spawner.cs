using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject misil;
    float timeAux;
    public float speed = 5f;
    public Vector2 mincampos, maxcampos;
    

    // Start is called before the first frame update
    void Start()
    {
        timeAux = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
       
            float timeDif = Time.time - timeAux;

            if (Input.GetKeyDown(KeyCode.W) && timeDif > 1f)
            {
                Vector3 pos = new Vector3(transform.position.x + 1.2f, transform.position.y + 0.1f, 1f);
                GameObject clone = Instantiate(misil, pos, Quaternion.identity) as GameObject;
                clone.SetActive(true);

                timeAux = Time.time;

            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);


            }

            if (Input.GetKey(KeyCode.X))
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);


            }

            float posX = transform.position.x;
            float posY = transform.position.y;

            transform.position = new Vector3(
               Mathf.Clamp(posX, mincampos.x, maxcampos.x),
              Mathf.Clamp(posY, mincampos.y, maxcampos.y),
               transform.position.z);
        
    }
   
}
