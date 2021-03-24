using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame
{
    public class FinishGame : MonoBehaviour
    {

        public static bool canFinish = false;
        void OnTriggerEnter(Collider other)
        {
            // detect if object is player (for multiplayer maybe
            // check if it is in a list of conected players and change
            // the respawnLocation for that player)
            if (other.gameObject.CompareTag("Player") && canFinish)
            {
                Debug.Log("You Won");

                GameObject player = GameObject.FindWithTag("Player");
                player.GetComponent<KartGame.KartSystems.ArcadeKart>().enabled = false;

            }
        }
    }
}

