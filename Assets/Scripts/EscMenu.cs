using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MLAPI;

public class EscMenu : MonoBehaviour
{
    private GameObject escMenu;
    private bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        escMenu = GameObject.FindWithTag("EscMenu");
        escMenu.SetActive(isShowing);

        GameObject escMenu_Disconnect = escMenu.transform.GetChild(2).gameObject;
        escMenu_Disconnect.GetComponent<Button>().onClick.AddListener(onSelectDisconnect);

        GameObject escMenu_Quit = escMenu.transform.GetChild(3).gameObject;
        escMenu_Quit.GetComponent<Button>().onClick.AddListener(onSelectQuit);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("toggling esc menu");
            isShowing = !isShowing;
            escMenu.SetActive(isShowing);

            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<KartGame.KartSystems.ArcadeKart>().enabled = !isShowing;
        }
    }

    void onSelectDisconnect()
    {
        Debug.Log("Disconnecting...");
        // TODO: disconnect from server host here
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        NetworkManager.Singleton.StopHost();
        NetworkManager.Singleton.StopClient();
    }

    void onSelectQuit()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
}
