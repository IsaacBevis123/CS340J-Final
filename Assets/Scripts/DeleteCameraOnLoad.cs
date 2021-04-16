using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Messaging;
using UnityEngine.Assertions;

public class DeleteCameraOnLoad : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*if (!IsOwner)
        {
            Debug.Log("removing second camera...");
            GetComponent<camera>.enabled = false;
        }*/
    }

    public override void NetworkStart()
    {
        if (!IsOwner)
        {
            Debug.Log("removing second camera...");
            GetComponent<Camera>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
