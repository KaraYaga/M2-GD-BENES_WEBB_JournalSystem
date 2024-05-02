//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Input/Input Actions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Actions"",
    ""maps"": [
        {
            ""name"": ""JournalNavigation"",
            ""id"": ""412e0a2c-fa5e-4014-b2cb-e71f2e5e1461"",
            ""actions"": [
                {
                    ""name"": ""Left Page"",
                    ""type"": ""Button"",
                    ""id"": ""3694f0a8-8f32-418e-8a9a-f4ff2c6c5468"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right Page"",
                    ""type"": ""Button"",
                    ""id"": ""f88ffc84-7504-4a44-85ad-e8e4804721df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Home"",
                    ""type"": ""Button"",
                    ""id"": ""6802de36-5f4d-458a-8d5c-22f3b5c2f94e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""449f6c13-379a-4b67-990a-27b2bf060d6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inputs"",
                    ""type"": ""Button"",
                    ""id"": ""07ad109d-84a4-484d-bba3-3882988efaae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a25662c3-3666-44d6-b555-b80646c947a0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left Page"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""268201e8-d2bf-4c60-9404-1cf7f82cfc25"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Left Page"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d000b8e9-e220-4e2e-aca5-ed8960402d3d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right Page"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eebe51f1-5255-4492-8a40-206f4fd89ed7"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Right Page"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""effd595b-5541-4066-8b1f-8167329fed49"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Home"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b8bb8d-b085-4494-b62f-8760eb53b7f6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Home"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35667159-a36b-42d4-aa30-c5e15200cbaf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73343681-aff9-49fb-abbc-77d208c304ca"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edcdab21-fbc0-41b0-940b-b3cea76a8a13"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Inputs"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f8e79a0-1d40-4be6-8eb8-1216f508d47c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inputs"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // JournalNavigation
        m_JournalNavigation = asset.FindActionMap("JournalNavigation", throwIfNotFound: true);
        m_JournalNavigation_LeftPage = m_JournalNavigation.FindAction("Left Page", throwIfNotFound: true);
        m_JournalNavigation_RightPage = m_JournalNavigation.FindAction("Right Page", throwIfNotFound: true);
        m_JournalNavigation_Home = m_JournalNavigation.FindAction("Home", throwIfNotFound: true);
        m_JournalNavigation_Options = m_JournalNavigation.FindAction("Options", throwIfNotFound: true);
        m_JournalNavigation_Inputs = m_JournalNavigation.FindAction("Inputs", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // JournalNavigation
    private readonly InputActionMap m_JournalNavigation;
    private List<IJournalNavigationActions> m_JournalNavigationActionsCallbackInterfaces = new List<IJournalNavigationActions>();
    private readonly InputAction m_JournalNavigation_LeftPage;
    private readonly InputAction m_JournalNavigation_RightPage;
    private readonly InputAction m_JournalNavigation_Home;
    private readonly InputAction m_JournalNavigation_Options;
    private readonly InputAction m_JournalNavigation_Inputs;
    public struct JournalNavigationActions
    {
        private @InputActions m_Wrapper;
        public JournalNavigationActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPage => m_Wrapper.m_JournalNavigation_LeftPage;
        public InputAction @RightPage => m_Wrapper.m_JournalNavigation_RightPage;
        public InputAction @Home => m_Wrapper.m_JournalNavigation_Home;
        public InputAction @Options => m_Wrapper.m_JournalNavigation_Options;
        public InputAction @Inputs => m_Wrapper.m_JournalNavigation_Inputs;
        public InputActionMap Get() { return m_Wrapper.m_JournalNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JournalNavigationActions set) { return set.Get(); }
        public void AddCallbacks(IJournalNavigationActions instance)
        {
            if (instance == null || m_Wrapper.m_JournalNavigationActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JournalNavigationActionsCallbackInterfaces.Add(instance);
            @LeftPage.started += instance.OnLeftPage;
            @LeftPage.performed += instance.OnLeftPage;
            @LeftPage.canceled += instance.OnLeftPage;
            @RightPage.started += instance.OnRightPage;
            @RightPage.performed += instance.OnRightPage;
            @RightPage.canceled += instance.OnRightPage;
            @Home.started += instance.OnHome;
            @Home.performed += instance.OnHome;
            @Home.canceled += instance.OnHome;
            @Options.started += instance.OnOptions;
            @Options.performed += instance.OnOptions;
            @Options.canceled += instance.OnOptions;
            @Inputs.started += instance.OnInputs;
            @Inputs.performed += instance.OnInputs;
            @Inputs.canceled += instance.OnInputs;
        }

        private void UnregisterCallbacks(IJournalNavigationActions instance)
        {
            @LeftPage.started -= instance.OnLeftPage;
            @LeftPage.performed -= instance.OnLeftPage;
            @LeftPage.canceled -= instance.OnLeftPage;
            @RightPage.started -= instance.OnRightPage;
            @RightPage.performed -= instance.OnRightPage;
            @RightPage.canceled -= instance.OnRightPage;
            @Home.started -= instance.OnHome;
            @Home.performed -= instance.OnHome;
            @Home.canceled -= instance.OnHome;
            @Options.started -= instance.OnOptions;
            @Options.performed -= instance.OnOptions;
            @Options.canceled -= instance.OnOptions;
            @Inputs.started -= instance.OnInputs;
            @Inputs.performed -= instance.OnInputs;
            @Inputs.canceled -= instance.OnInputs;
        }

        public void RemoveCallbacks(IJournalNavigationActions instance)
        {
            if (m_Wrapper.m_JournalNavigationActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJournalNavigationActions instance)
        {
            foreach (var item in m_Wrapper.m_JournalNavigationActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JournalNavigationActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JournalNavigationActions @JournalNavigation => new JournalNavigationActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IJournalNavigationActions
    {
        void OnLeftPage(InputAction.CallbackContext context);
        void OnRightPage(InputAction.CallbackContext context);
        void OnHome(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
        void OnInputs(InputAction.CallbackContext context);
    }
}