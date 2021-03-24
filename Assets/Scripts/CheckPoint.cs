using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame
{
    public class CheckPoint : MonoBehaviour
    {
        public GameObject respawnLocation;
        public bool isLast;

        void OnTriggerEnter(Collider other)
        {
            // detect if object is player (for multiplayer maybe
            // check if it is in a list of conected players and change
            // the respawnLocation for that player)
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Checkpoint saved...");
                Vector3 loc = this.gameObject.transform.position;

                respawnLocation.transform.position = loc;
                respawnLocation.transform.rotation = this.gameObject.transform.rotation;
            }

            if (isLast)
            {
                FinishGame.canFinish = true;
            }
        }
    }
}

