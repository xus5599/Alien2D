using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 mincampos, maxcampos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);


        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);


        }

        float posX = transform.position.x;
        float posY = transform.position.y;

        transform.position = new Vector3(
           Mathf.Clamp(posX, mincampos.x, maxcampos.x),
          Mathf.Clamp(posY, mincampos.y, maxcampos.y),
           transform.position.z);
    }
}
