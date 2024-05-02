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
        inputAction.Disable();
        rebindOperation = inputAction.PerformInteractiveRebinding()
            .WithControlsExcluding("<Keyboard>/escape")
            .WithControlsExcluding("<Mouse>/leftButton")
            .WithControlsExcluding("<Gamepad>/leftStick/down")
            .WithControlsExcluding("<Gamepad>/leftStick/up")
            .WithControlsExcluding("<Gamepad>/leftStick/right")
            .WithControlsExcluding("<Gamepad>/leftStick/left")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete());

        rebindOperation.Start();
        inputAction.Enable();
    }

    public void RebindComplete()
    {
        UpdateBindingUI();
        rebindOperation.Dispose();
    }

    public void UpdateBindingUI()
    {
        PlayerInput playerInput = JournalNavigation.instance.GetPlayerInput();

        int bindingIndex = actionRef.action.GetBindingIndexForControl(actionRef.action.controls[0]);

        if (playerInput.currentControlScheme == "Keyboard")
        {
            

            Debug.Log(InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice));

            if (InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice) == "Left Button" ||
                    InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice) == "Press")
            {
                bindingText.text = "";
                spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite("leftButton");

                spriteIcon.SetActive(true);

            }
            else if (InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice) == "Right Button")
            {
                bindingText.text = "";
                spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite("rightButton");
                spriteIcon.SetActive(true);
            }
            else
            {
                spriteIcon.SetActive(false);
                bindingText.text = InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice);
            }
        }
        else if(playerInput.currentControlScheme == "Gamepad")
        {
            Debug.Log("Gamepad");
            bindingText.text = "";

            string controlPath = InputControlPath.ToHumanReadableString(
                    actionRef.action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice);

            spriteIcon.GetComponent<Image>().sprite = IconBinding.instance.allIcons.GetSprite(controlPath);
            Debug.Log(controlPath);
            spriteIcon.SetActive(true);
        }

    }
}
