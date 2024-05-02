using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManagerScript : MonoBehaviour
{
    public static CanvasManagerScript instance;
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject Input;
    private bool isInJournal;


    private void Awake()
    {
        instance = this;
    }

    //ON START
    public void Start()
    {
        Options.SetActive(false);
        Input.SetActive(false);
        isInJournal = true;
    }

    // HOME MENU OPEN AND CLOSE
    public void homeButton()
    {
        SceneManager.LoadScene("Menu");
        isInJournal = true;
    }

    // OPTIONS MENU OPEN AND CLOSE
    public void optionsButton()
    {
        isInJournal = false;
        Options.SetActive(true);
        Input.SetActive(false);
    }
    public void closeOptions() 
    {
        isInJournal = true;
        Options.SetActive(false);
    }

    // INPUT MENU OPEN AND CLOSE
    public void inputButton()
    {
        isInJournal = false;
        Input.SetActive(true);
        Options.SetActive(false);
    }
    public void closeInput()
    {
        isInJournal = true;
        Input.SetActive(false);
    }

    public bool GetInsInJournal()
    {
        return isInJournal;
    }
}
