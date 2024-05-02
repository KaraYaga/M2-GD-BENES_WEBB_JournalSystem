using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JournalNavigation : MonoBehaviour
{
    public static JournalNavigation instance;
    [SerializeField] private List<GameObject> pages = new List<GameObject>();
    CanvasManagerScript canvaManager;
    PlayerInput playerInput;
    private int pagesPos = 0;

    private void Awake()
    {
        instance = this;    
    }

    private void Start()
    {
        canvaManager = CanvasManagerScript.instance;
        playerInput = gameObject.GetComponent<PlayerInput>();
    }

    public void RightPage(InputAction.CallbackContext context)
    {
        if (!ClickableButton.hovered && context.performed && pagesPos < pages.Count - 1 && canvaManager.GetInsInJournal())
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos++;
            pages[pagesPos].gameObject.SetActive(true);
        }
    }

    public void LastPage(InputAction.CallbackContext context)
    {
        if (!ClickableButton.hovered && context.performed && pagesPos > 0 && canvaManager.GetInsInJournal())
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos--;
            pages[pagesPos].gameObject.SetActive(true);
        }
    }

    public PlayerInput GetPlayerInput()
    {
        return playerInput;
    }
}
