using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject TrackSelectionPanel;

    
    void Start(){
        TrackSelectionPanel.SetActive(false);
    }

    public void Play(){
        MainMenuPanel.SetActive(false);
        TrackSelectionPanel.SetActive(true);
    }


    public void Quit(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void selectTrack1(){
        Debug.Log("Loading track 1...");
        SceneManager.LoadScene("Track1", LoadSceneMode.Single);
        TrackSelectionPanel.SetActive(false);
    }

    public void selectTrack2(){
        Debug.Log("Loading track 2...");
        SceneManager.LoadScene("Track2", LoadSceneMode.Single);
        TrackSelectionPanel.SetActive(false);
    }
    public void selectTrack3(){
        Debug.Log("Loading track 3...");
        SceneManager.LoadScene("Track3", LoadSceneMode.Single);
        TrackSelectionPanel.SetActive(false);
    }
}
