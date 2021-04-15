using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Transports.UNET;
using UnityEngine.UI;

public class HostMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPanel;
    public InputField inputField;
    
    public void Host(){
        NetworkManager.Singleton.ConnectionApprovalCallback += GameObject.FindWithTag("Network").GetComponent<ConnectionApproval>().ApprovalCheck;
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join(){
        //clicked join
        if (inputField.text.Length <= 0){
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = "127.0.0.1";
        }
        else{
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = inputField.text;
        }
        NetworkManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("test"); // this could be used to make a password to the server and/or a game version check.
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
}
