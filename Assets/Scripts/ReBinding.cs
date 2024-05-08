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
    private PlayerInput playerInput;

    void Start()
    {
        inputAction = actionRef;
        UpdateBindingUI();
    }

    public void StartRebind() 
    {
        CanvasManagerScript.instance.GetWaitForInput().SetActive(true);

        playerInput = JournalNavigation.instance.GetPlayerInput();

        if(playerInput.currentControlScheme == "Keyboard")
        {
            inputAction.Disable();
            rebindOperation = inputAction.PerformInteractiveRebinding()
                .WithBindingGroup("Keyboard")
                .WithControlsExcluding("<Keyboard>/escape")
                .WithControlsExcluding("<Mouse>/leftButton")
                .WithControlsExcluding("<Mouse>/press")
                .WithControlsExcluding("<Gamepad>/anyKey")
                .OnMatchWaitForAnother(0.1f)
                .OnComplete(operation => RebindComplete());

            rebindOperation.Start();
            inputAction.Enable();
        }
        else if(playerInput.currentControlScheme == "Gamepad")
        {
            inputAction.Disable();
            rebindOperation = inputAction.PerformInteractiveRebinding()
                .WithBindingGroup("Gamepad")
                .WithControlsExcluding("<Gamepad>/leftStick/down")
                .WithControlsExcluding("<Gamepad>/leftStick/up")
                .WithControlsExcluding("<Gamepad>/leftStick/right")
                .WithControlsExcluding("<Gamepad>/leftStick/left")
                .WithControlsExcluding("<Gamepad>/buttonSouth")
                .WithControlsExcluding("<Gamepad>/start")
                .WithControlsExcluding("<Gamepad>/select")
                .WithControlsExcluding("<Keyboard>/anyKey")
                .OnMatchWaitForAnother(0.1f)
                .OnComplete(operation => RebindComplete());

            rebindOperation.Start();
            inputAction.Enable();
        }
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
        playerInput = JournalNavigation.instance.GetPlayerInput();

        int bindingIndex = actionRef.action.GetBindingIndexForControl(actionRef.action.controls[0]);
        Debug.Log(bindingIndex);

        //Debug.Log(InputControlPath.ToHumanReadableString(
        //  actionRef.action.bindings[bindingIndex].effectivePath,
        //  InputControlPath.HumanReadableStringOptions.OmitDevice));

        string controlPath = InputControlPath.ToHumanReadableString(
          actionRef.action.bindings[bindingIndex].effectivePath,
          InputControlPath.HumanReadableStringOptions.OmitDevice);

        if (playerInput.currentControlScheme == "Keyboard")
        {
            //foreach (var binding in actionRef.action.bindings)
            //{

                //Debug.Log(InputControlPath.ToHumanReadableString(
                //    binding.effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice));
            //}

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
