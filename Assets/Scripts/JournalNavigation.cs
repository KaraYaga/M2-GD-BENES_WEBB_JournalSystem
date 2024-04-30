using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JournalNavigation : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages = new List<GameObject>();
    private int pagesPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightPage(InputAction.CallbackContext context)
    {
        if (context.performed && pagesPos < pages.Count)
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos++;
            pages[pagesPos].gameObject.SetActive(true);
        }
    }

    public void LastPage(InputAction.CallbackContext context)
    {
        if (context.performed && pagesPos > 0)
        {
            pages[pagesPos].gameObject.SetActive(false);
            pagesPos--;
            pages[pagesPos].gameObject.SetActive(true);
        }
    }
}
