using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscapeManager : MonoBehaviour
{
    public GameObject escapeMenu;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("toggling esc menu");
            escapeMenu.SetActive(!escapeMenu.activeSelf);

            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<KartGame.KartSystems.ArcadeKart>().enabled = false;
        }
    }
    
    public void Disconnect(){
        Debug.Log("Disconnecting...");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        NetworkManager.Singleton.StopHost();
        NetworkManager.Singleton.StopClient();
    }

    public void Quit(){
        Debug.Log("Quiting...");
        Application.Quit();
    }

}
