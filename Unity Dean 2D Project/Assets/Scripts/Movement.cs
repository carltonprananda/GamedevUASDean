using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float maxspeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow)) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -speed, 0);
            // transform.Translate(0, -speed, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed, 0);
            // transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-speed,0, 0);
            // transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
            // transform.Translate(speed, 0, 0);
        }

        if (maxspeed >= speed)
        {
            speed += 0.01f;
        }
    }
}
