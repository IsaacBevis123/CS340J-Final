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
    public InputField inputJoin;
    
    public void Host(){
        NetworkManager.Singleton.ConnectionApprovalCallback += GameObject.FindWithTag("Network").GetComponent<ConnectionApproval>().ApprovalCheck;
        NetworkManager.Singleton.StartHost();
        menuPanel.SetActive(false);
    }

    public void Join(){
        //clicked join
        if (inputJoin.text.Length <= 0){
            Debug.Log("attempting to join 127.0.0.1......");
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = "127.0.0.1";
        }
        else{
            Debug.Log("attempting to join " + inputJoin.text);
            NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = inputJoin.text;
        }
        NetworkManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("test"); // this could be used to make a password to the server and/or a game version check.
        NetworkManager.Singleton.StartClient();
        menuPanel.SetActive(false);
    }
}
