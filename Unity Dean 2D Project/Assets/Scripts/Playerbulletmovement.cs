using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbulletmovement : MonoBehaviour

{
    //Rigidbody2D rbbullet;
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        bulletspeed = 4f;
    }

    // Update is called once per frame
    void OnBecameInvisible()
    {
        Vector2 positionbullet = transform.position;

        positionbullet = new Vector2(positionbullet.x, positionbullet.y + bulletspeed * Time.deltaTime);
        transform.position = positionbullet;

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2 (1, 1));

        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }
}
