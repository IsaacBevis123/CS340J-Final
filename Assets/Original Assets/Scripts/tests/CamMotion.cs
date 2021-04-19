using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame
{
    public class CamMotion : MonoBehaviour
    {
        private GameObject camera;
        private GameObject[] path;

        private GameObject moveTo;
        // Start is called before the first frame update
        void Start()
        {
            camera = GameObject.FindWithTag("MainCamera");
            path = GameObject.FindGameObjectsWithTag("CameraPath");
            // prevent player from moving
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<KartGame.KartSystems.ArcadeKart>().enabled = false;

            // play begining game animation
            startAnimation();
        }

        public void winAnimation()
        {

        }

        public void startAnimation()
        {
            Debug.Log("animation started....");
            foreach (GameObject o in path)
            {
                moveTo = o;
            }
        }

        /*public void MoveTo(GameObject moveTo)
        {
            if (moveTo != null)
            {
                Vector3 movement = moveTo.transform.position - camera.transform.position;
                Debug.Log(camera.transform.position + movement);
                camera.GetComponent<Rigidbody>().MovePosition(camera.transform.position + movement * Time.deltaTime * 3f);
                camera.GetComponent<Rigidbody>().MoveRotation(moveTo.transform.rotation);
            }
            
        }*/

        void Update()
        {
            Rigidbody cam_rigidbody = camera.GetComponent<Rigidbody>();
            Vector3 movement = moveTo.transform.position - camera.transform.position;
            Vector3 rotation = new Vector3(0, 100, 0);
            Quaternion deltaRotation = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            cam_rigidbody.MovePosition(camera.transform.position + movement * Time.deltaTime * 1f);
            cam_rigidbody.MoveRotation(cam_rigidbody.rotation * deltaRotation);
        }

    }
}

