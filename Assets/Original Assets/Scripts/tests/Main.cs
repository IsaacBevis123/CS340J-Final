using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame
{
    public class Main : MonoBehaviour
    {
        
        private CamMotion cam;
        // Start is called before the first frame update
        void Start()
        {
            // prevent player from moving
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<KartGame.KartSystems.ArcadeKart>().enabled = false;

            // play begining game animation
            cam = new CamMotion();
            cam.startAnimation();
        }

        // Update is called once per frame
        static void Update()
        {
        }
    }
}

