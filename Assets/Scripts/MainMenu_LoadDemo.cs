using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu_LoadDemo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject MenuCam;

    // Executes when cursor passes over the game object
    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("name: " + name);
        
        try
        {
            SceneManager.LoadScene(name + "-Demo", LoadSceneMode.Additive);
            MenuCam.SetActive(false);
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
    }
}
