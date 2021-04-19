using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu_LoadDemo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Track1Pic;
    public GameObject Track2Pic;
    public GameObject Track3Pic;

    void Start()
    {
        // make pictures invisible on load
        Track1Pic.SetActive(false);
        Track2Pic.SetActive(false);
        Track3Pic.SetActive(false);
    }

    // Executes when cursor passes over the game object
    public void OnPointerEnter(PointerEventData data)
    {
        // name is local variable that represents the name of the object hovered over
        //      accesible inside OnPointerEnter provided by unity

        if (name == "Track1")
        {
            Track1Pic.SetActive(true);
        }
        else if (name == "Track2")
        {
            Track2Pic.SetActive(true);
        }
        else if (name == "Track3")
        {
            Track3Pic.SetActive(true);
        }

        Debug.Log("name: " + name);
    }

    // Executes when cursor leaves the game object
    public void OnPointerExit(PointerEventData data)
    {
        Track1Pic.SetActive(false);
        Track2Pic.SetActive(false);
        Track3Pic.SetActive(false);
    }
}
