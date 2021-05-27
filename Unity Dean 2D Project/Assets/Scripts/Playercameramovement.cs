using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercameramovement : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 playerposition;
    public float offsetSmoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerposition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        if (player.transform.localScale.x > 0f)
        {
            playerposition = new Vector3(playerposition.x + offset, playerposition.y, playerposition.z);
        }
        else
        {
            playerposition = new Vector3(playerposition.x - offset, playerposition.y, playerposition.z);
        }
        transform.position = Vector3.Lerp(transform.position, playerposition, offsetSmoothing * Time.deltaTime);
    }
}

