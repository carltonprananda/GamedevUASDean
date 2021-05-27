using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershootmovement : MonoBehaviour
{
    public GameObject bullet;
    public float delayTime;
    bool shooting = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shooting && Input.GetKey(KeyCode.Space))
        {
            shooting = false;
            Instantiate(bullet, transform.position, transform.rotation);
            StartCoroutine(NoFire());
        }
    }

    IEnumerator NoFire()
    {
        yield return new WaitForSeconds(delayTime);
        shooting = true;
    }
}
