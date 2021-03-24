using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour

{
    public GameObject respawnLocation;
    public int deathLine;
    private Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("y pos is: " + player.transform.position.y);
        if (player.transform.position.y <= deathLine) {
            Debug.Log("Respawning player...");
            respawnPlayer();
        }
    }

    void respawnPlayer()
    {
        // set player velocity to 0
        player.velocity = new Vector3(0, 0, 0);

        // teleport player to respawn location
        Vector3 p = respawnLocation.transform.position;
        player.transform.position = p;

        //rotate player to be facing forward on track
        player.transform.rotation = respawnLocation.transform.rotation;
    }
}
