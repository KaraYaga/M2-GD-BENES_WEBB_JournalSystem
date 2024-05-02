using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReBinding : MonoBehaviour
{
    [SerializeField] private InputActionReference actionRef;
    [SerializeField] private TMP_Text bindingText;
    private InputAction inputAction;
    private InputActionRebindingExtensions.RebindingOperation rebindOperation;

    void Start()
    {
        inputAction = actionRef;
        UpdateBindingUI();
    }

    private void Update()
    {
        Debug.Log(GetComponent<PlayerInput>().currentControlScheme);
    }

    public void StartRebind() 
    {
        inputAction.Disable();
        rebindOperation = inputAction.PerformInteractiveRebinding()
            .WithControlsExcluding("<Keyboard>/escape")
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

    void UpdateBindingUI()
    {
        //if keyboard --> do that else if gamepad --> do that
        int bindingIndex = actionRef.action.GetBindingIndexForControl(actionRef.action.controls[0]);

        bindingText.text = InputControlPath.ToHumanReadableString(
            actionRef.action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
    }
}
