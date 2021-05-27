using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    float maxspeed = 2f;
    float playerspeed = 1f;
    float rotspeed = 180f;
    //public float cameraposition = 20f;

    float spaceshipboundary = 2f;

    private GameObject Player;
    public GameObject BulletGroup;
    public GameObject PlayerBulletPos1;
    public GameObject PlayerBulletPos2;

    public AudioClip audioClip;
    public AudioSource PlayerSource;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //GameObject bullet1 = (GameObject)Instantiate(BulletGroup);
            //bullet1.transform.position = PlayerBulletPos1.transform.position;

            //GameObject bullet2 = (GameObject)Instantiate(BulletGroup);
            //bullet2.transform.position = PlayerBulletPos2.transform.position;
        //}
        //float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");
        //float z = Input.GetAxis("Mouse X");

        //Vector2 directionplayer = new Vector2(x, y).normalized;

        //Move(directionplayer);
        //First Phase
        Quaternion playerrot = transform.rotation;
        float posz = playerrot.eulerAngles.z;
        posz -=  Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        playerrot = Quaternion.Euler(0, 0, posz);
        transform.rotation = playerrot;
        
        Vector3 playerpos = transform.position;
        //playerpos = Camera.main.ScreenToWorldPoint(playerpos);
        playerpos.z += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        playerpos.y += Input.GetAxis("Vertical") * playerspeed *  Time.deltaTime;

        rb2d.velocity = Vector2.zero;
        float verticalvelocity = Input.GetAxis("Vertical") * playerspeed * Time.deltaTime;
        Vector3 playervelocity = new Vector3(0, verticalvelocity, 0);
        playerpos += playerrot * playervelocity;

        if(Input.GetButtonDown("Vertical") && maxspeed > playerspeed)
        {
            playerspeed+= 0.1f;
        } 
        if (playerspeed <= 0f)
        {
            playerspeed = 0f;
        }
        transform.position = playerpos;
    }

    //void Move(Vector2 directionplayer)
    //{//
        //Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        //Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //max.x= max.x - 0.5f;
        //min.x = min.x + 0.5f;

        //max.y = max.y - 0.5f;
        //min.y = min.y + 0.5f;

       // Vector2 positionplayer = transform.position;

        //positionplayer += directionplayer * playerspeed * Time.deltaTime;

        //positionplayer.x = Mathf.Clamp(positionplayer.x, min.x, max.x);
        //positionplayer.y = Mathf.Clamp(positionplayer.y, min.y, max.y);

        //transform.position = positionplayer;
    //}


}
