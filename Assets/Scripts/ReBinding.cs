using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReBinding : MonoBehaviour
{
    [SerializeField] private InputActionReference action;
    private InputAction inputAction;
    private InputActionRebindingExtensions.RebindingOperation rebindOperation;

    void Start()
    {
        inputAction = action;
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
        rebindOperation.Dispose();
    }
}
