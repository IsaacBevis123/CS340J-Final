using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class HostMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPanel;
    
    public void Host(){
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join(){
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
}
