using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace KartGame
{
    public class MainMenu : MonoBehaviour
    {

        private GameObject mainMenu;

        private GameObject trackSelectMenu;

        // Start is called before the first frame update
        void Start()
        {
            mainMenu = GameObject.FindWithTag("MainMenu_Screen1");
            trackSelectMenu = GameObject.FindWithTag("MainMenu_Screen3");

            setMenuVisibility(true, false);
            setButtonEvents();
        }

        void setButtonEvents()
        {
            // play button in main menu
            GameObject mainMenu_Play = mainMenu.transform.GetChild(1).gameObject;
            mainMenu_Play.GetComponent<Button>().onClick.AddListener(onSelectPlay);

            // quit button in main menu
            GameObject mainMenu_Quit = mainMenu.transform.GetChild(2).gameObject;
            mainMenu_Quit.GetComponent<Button>().onClick.AddListener(onSelectQuit);


            // track one button in track select
            GameObject trackSelect_1 = trackSelectMenu.transform.GetChild(1).gameObject;
            trackSelect_1.GetComponent<Button>().onClick.AddListener(onSelectTrack1);

            // track two button in track select
            GameObject trackSelect_2 = trackSelectMenu.transform.GetChild(2).gameObject;
            trackSelect_2.GetComponent<Button>().onClick.AddListener(onSelectTrack2);

            // track three button in track select
            GameObject trackSelect_3 = trackSelectMenu.transform.GetChild(3).gameObject;
            trackSelect_3.GetComponent<Button>().onClick.AddListener(onSelectTrack3);

            // track four button in track select
            GameObject trackSelect_4 = trackSelectMenu.transform.GetChild(4).gameObject;
            trackSelect_4.GetComponent<Button>().onClick.AddListener(onSelectTrack4);

            // track five button in track select
            GameObject trackSelect_5 = trackSelectMenu.transform.GetChild(5).gameObject;
            trackSelect_5.GetComponent<Button>().onClick.AddListener(onSelectTrack5);
        }

        void setMenuVisibility(bool menu1, bool menu3)
        {
            mainMenu.SetActive(menu1);
            trackSelectMenu.SetActive(menu3);
        }

        void onSelectPlay()
        {
            Debug.Log("Play Button pressed");
            setMenuVisibility(false, true);
        }

        void onSelectQuit()
        {
            Debug.Log("Quit Button pressed");
            Application.Quit();
        }


        void onSelectTrack1()
        {
            Debug.Log("Loading track 1...");
            SceneManager.LoadScene("Track1", LoadSceneMode.Single);
        }

        void onSelectTrack2()
        {
            Debug.Log("Loading track 2...");
            SceneManager.LoadScene("Track2", LoadSceneMode.Single);
        }

        void onSelectTrack3()
        {
            Debug.Log("Loading track 3...");
            SceneManager.LoadScene("Track3", LoadSceneMode.Single);
        }

        void onSelectTrack4()
        {
            Debug.Log("Loading track 4...");
        }

        void onSelectTrack5()
        {
            Debug.Log("Loading track 5...");
        }
    }
}
