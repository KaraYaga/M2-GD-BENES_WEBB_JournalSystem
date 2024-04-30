using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JournalNavigation : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages = new List<GameObject>();
    private int pagesPos = 0;
    CanvasManagerScript canvaManager;

    private void Start()
    {
        canvaManager = CanvasManagerScript.instance;
    }

    public void RightPage(InputAction.CallbackContext context)
    {
        if (!ClickableButton.hovered && context.performed && pagesPos < pages.Count - 1 && canvaManager.GetInsInJournal())
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos++;
            pages[pagesPos].gameObject.SetActive(true);
            Debug.Log(pagesPos);
        }
    }

    public void LastPage(InputAction.CallbackContext context)
    {
        if (!ClickableButton.hovered && context.performed && pagesPos > 0 && canvaManager.GetInsInJournal())
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos--;
            pages[pagesPos].gameObject.SetActive(true);
            Debug.Log(pagesPos);
        }
    }
}
