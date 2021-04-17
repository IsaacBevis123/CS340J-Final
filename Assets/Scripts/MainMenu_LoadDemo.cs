using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu_LoadDemo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject mainCamera;
    public UnityEngine.Video.VideoClip playedVideo;
    private UnityEngine.Video.VideoPlayer videoPlayer;

    void Start()
    {

        videoPlayer = mainCamera.AddComponent<UnityEngine.Video.VideoPlayer>();

        // Make sure video doesnt start automatically.
        videoPlayer.playOnAwake = false;

        videoPlayer.isLooping = true;

        // Make video invisible when not playing
        videoPlayer.targetCameraAlpha = 0.0f;
    }

    // Executes when cursor passes over the game object
    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("name: " + name);

        try
        {
            videoPlayer.clip = playedVideo;
            videoPlayer.targetCameraAlpha = 1.0f;
            videoPlayer.Play();
        }

        catch (Exception e)
        {
            Debug.Log(name + " does not exist.");
            Debug.Log(e);
        }
    }

    // Executes when cursor leaves the game object
    public void OnPointerExit(PointerEventData data)
    {
        Debug.Log("leaving...");
        videoPlayer.targetCameraAlpha = 0.0f;
        videoPlayer.Stop();
    }
}
