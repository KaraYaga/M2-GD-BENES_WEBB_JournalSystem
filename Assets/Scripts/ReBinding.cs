using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ReBinding : MonoBehaviour
{
    [SerializeField] private InputActionReference actionRef;
    [SerializeField] private TMP_Text bindingText;
    [SerializeField] private GameObject spriteIcon;
    private InputAction inputAction;
    private InputActionRebindingExtensions.RebindingOperation rebindOperation;

    void Start()
    {
        inputAction = actionRef;
        UpdateBindingUI();
    }

    public void StartRebind() 
    {
        CanvasManagerScript.instance.GetWaitForInput().SetActive(true);

        inputAction.Disable();
        rebindOperation = inputAction.PerformInteractiveRebinding()
            .WithControlsExcluding("<Keyboard>/escape")
            .WithControlsExcluding("<Mouse>/leftButton")
            .WithControlsExcluding("<Mouse>/press")
            .WithControlsExcluding("<Gamepad>/leftStick/down")
            .WithControlsExcluding("<Gamepad>/leftStick/up")
            .WithControlsExcluding("<Gamepad>/leftStick/right")
            .WithControlsExcluding("<Gamepad>/leftStick/left")
            .WithControlsExcluding("<Gamepad>/buttonSouth")
            .WithControlsExcluding("<Gamepad>/start")
            .WithControlsExcluding("<Gamepad>/select")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete());

        rebindOperation.Start();
        inputAction.Enable();
    }

    public void RebindComplete()
    {
        CanvasManagerScript.instance.GetWaitForInput().SetActive(false);
        rebindOperation.Dispose();
        UpdateBindingUI();
    }

    public void UpdateBindingUI()
    {
        //*********************************************************NEED TO FIX : ui don't update gamepad if changed before (only update the one before that) 
        PlayerInput playerInput = JournalNavigation.instance.GetPlayerInput();

        int bindingIndex = actionRef.action.GetBindingIndexForControl(actionRef.action.controls[0]);

        string controlPath = InputControlPath.ToHumanReadableString(
          actionRef.action.bindings[bindingIndex].effectivePath,
          InputControlPath.HumanReadableStringOptions.OmitDevice);

        if (playerInput.currentControlScheme == "Keyboard")
        {
            if (controlPath == "Left Button" || controlPath == "Press")
            {
                bindingText.text = "";
                spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite(controlPath);

                spriteIcon.SetActive(true);

            }
            else if (controlPath == "Right Button")
            {
                bindingText.text = "";
                spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite(controlPath);
                spriteIcon.SetActive(true);
            }
            else
            {
                spriteIcon.SetActive(false);
                bindingText.text = controlPath;
            }
        }
        else if(playerInput.currentControlScheme == "Gamepad")
        {
            bindingText.text = "";
            spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite(controlPath);
            spriteIcon.SetActive(true);
        }

    }
}
