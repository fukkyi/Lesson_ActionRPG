// GENERATED AUTOMATICALLY FROM 'Assets/App/Settings/InputSystem/BasicInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BasicInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BasicInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BasicInputAction"",
    ""maps"": [
        {
            ""name"": ""Debug"",
            ""id"": ""d82ab577-d52f-4503-940c-9c8d72722715"",
            ""actions"": [
                {
                    ""name"": ""ToggleDebugMode"",
                    ""type"": ""Button"",
                    ""id"": ""b0de74f7-b239-478e-ad8d-9127467b202b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnableConsole"",
                    ""type"": ""Button"",
                    ""id"": ""1d290556-c2e6-4532-9b28-d7105d28caa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DisableConsole"",
                    ""type"": ""Button"",
                    ""id"": ""7d5d8403-786d-408f-afd1-46e5fb3aec1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c90df856-39b5-497e-ae67-38f925a81aeb"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDebugMode"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""a6e04050-e662-4107-9cf7-32fba5595e3f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDebugMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""2028099b-5e88-4a24-9fe9-f12eee17d1e2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDebugMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3b7ee2e-df11-48c1-9a4c-297512b2af85"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87f950dc-7e1c-4f65-b05d-a17f1e859e0b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DisableConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_ToggleDebugMode = m_Debug.FindAction("ToggleDebugMode", throwIfNotFound: true);
        m_Debug_EnableConsole = m_Debug.FindAction("EnableConsole", throwIfNotFound: true);
        m_Debug_DisableConsole = m_Debug.FindAction("DisableConsole", throwIfNotFound: true);
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

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_ToggleDebugMode;
    private readonly InputAction m_Debug_EnableConsole;
    private readonly InputAction m_Debug_DisableConsole;
    public struct DebugActions
    {
        private @BasicInputAction m_Wrapper;
        public DebugActions(@BasicInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleDebugMode => m_Wrapper.m_Debug_ToggleDebugMode;
        public InputAction @EnableConsole => m_Wrapper.m_Debug_EnableConsole;
        public InputAction @DisableConsole => m_Wrapper.m_Debug_DisableConsole;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @ToggleDebugMode.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebugMode;
                @ToggleDebugMode.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebugMode;
                @ToggleDebugMode.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebugMode;
                @EnableConsole.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnEnableConsole;
                @EnableConsole.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnEnableConsole;
                @EnableConsole.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnEnableConsole;
                @DisableConsole.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisableConsole;
                @DisableConsole.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisableConsole;
                @DisableConsole.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnDisableConsole;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleDebugMode.started += instance.OnToggleDebugMode;
                @ToggleDebugMode.performed += instance.OnToggleDebugMode;
                @ToggleDebugMode.canceled += instance.OnToggleDebugMode;
                @EnableConsole.started += instance.OnEnableConsole;
                @EnableConsole.performed += instance.OnEnableConsole;
                @EnableConsole.canceled += instance.OnEnableConsole;
                @DisableConsole.started += instance.OnDisableConsole;
                @DisableConsole.performed += instance.OnDisableConsole;
                @DisableConsole.canceled += instance.OnDisableConsole;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IDebugActions
    {
        void OnToggleDebugMode(InputAction.CallbackContext context);
        void OnEnableConsole(InputAction.CallbackContext context);
        void OnDisableConsole(InputAction.CallbackContext context);
    }
}
