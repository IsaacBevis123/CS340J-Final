using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KartSpawn : MonoBehaviour
{
    private Rigidbody player;
    public GameObject spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();

         if (spawnLocation == null) 
            {
                spawnLocation = GameObject.FindWithTag("Spawn");    
            }
            Vector3 p = spawnLocation.transform.position;
            Quaternion r = spawnLocation.transform.rotation;
            player.transform.position = p;
            player.transform.rotation = r;
    }

    
}
