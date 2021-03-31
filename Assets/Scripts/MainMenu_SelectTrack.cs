using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_SelectTrack : MonoBehaviour
{
    private GameObject trackSelectMenu;

    // Start is called before the first frame update
    void Start()
    {
        trackSelectMenu = GameObject.FindWithTag("MainMenu_Screen3");

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

    void onSelectTrack1()
    {
        Debug.Log("Loading track 1...");
    }

    void onSelectTrack2()
    {
        Debug.Log("Loading track 2...");
        SceneManager.LoadScene("Track2", LoadSceneMode.Single);
    }

    void onSelectTrack3()
    {
        Debug.Log("Loading track 3...");
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
