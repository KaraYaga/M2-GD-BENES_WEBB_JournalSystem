using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject Input;

    //ON START
    public void Start()
    {
        Options.SetActive(false);
        Input.SetActive(false);
    }

    // HOME MENU OPEN AND CLOSE
    public void homeButton()
    {
        SceneManager.LoadScene("Menu");
    }

    // OPTIONS MENU OPEN AND CLOSE
    public void optionsButton()
    {
        Options.SetActive(true);
    }
    public void closeOptions() 
    { 
        Options.SetActive(false );
    }

    // INPUT MENU OPEN AND CLOSE
    public void inputButton()
    {
        Input.SetActive(true);
    }
    public void closeInput()
    {
        Input.SetActive(false);
    }
}
