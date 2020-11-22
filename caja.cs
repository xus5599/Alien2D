using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public float speed;
    public Transform target;
    private Vector3 start, end;

    public GameObject alien;
    float timeAux;
    // Start is called before the first frame update
    void Start()
    {
        timeAux = Time.time;
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float timeDif = Time.time - timeAux;

        if (timeDif > 1f)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, 1f);
            GameObject clone = Instantiate(alien, pos, Quaternion.identity) as GameObject;
            clone.SetActive(true);

            timeAux = Time.time;

        }
    if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);

        }

        if (transform.position == target.position)
        {
            target.position = (target.position == start) ? end : start;
        }
    }

   

}
