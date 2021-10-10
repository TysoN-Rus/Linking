// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputControll.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControll : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControll"",
    ""maps"": [
        {
            ""name"": ""KeyboardMouse"",
            ""id"": ""866cc1cf-7458-43a7-915a-1a20fabaedae"",
            ""actions"": [
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""6d53419b-1969-458f-a7c2-dbcdd0733fd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PositionMouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6eae9c9b-2840-4f96-9371-9eb9b7197a40"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WASD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0409e86d-6b8c-44d5-843e-eb17d84283ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e55d18e4-9e84-4642-a9f3-8d7dca2fed0b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f2b9909-fee7-4f71-ae5d-e51cdf6af0ea"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PositionMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c74ca67e-d187-4565-8121-cc0c0e117394"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d7bd56e2-038f-48b8-baf2-cd9832af6a3d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24fafa23-79cb-498d-8879-e36ab770a594"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fc6b0cb5-3106-47f1-82d1-cf9fd24fa9b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""044678b2-ebb4-4c71-9c5a-5ba52b24b50f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardMouse
        m_KeyboardMouse = asset.FindActionMap("KeyboardMouse", throwIfNotFound: true);
        m_KeyboardMouse_Down = m_KeyboardMouse.FindAction("Down", throwIfNotFound: true);
        m_KeyboardMouse_PositionMouse = m_KeyboardMouse.FindAction("PositionMouse", throwIfNotFound: true);
        m_KeyboardMouse_WASD = m_KeyboardMouse.FindAction("WASD", throwIfNotFound: true);
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

    // KeyboardMouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_Down;
    private readonly InputAction m_KeyboardMouse_PositionMouse;
    private readonly InputAction m_KeyboardMouse_WASD;
    public struct KeyboardMouseActions
    {
        private @InputControll m_Wrapper;
        public KeyboardMouseActions(@InputControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @Down => m_Wrapper.m_KeyboardMouse_Down;
        public InputAction @PositionMouse => m_Wrapper.m_KeyboardMouse_PositionMouse;
        public InputAction @WASD => m_Wrapper.m_KeyboardMouse_WASD;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @Down.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnDown;
                @PositionMouse.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPositionMouse;
                @PositionMouse.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPositionMouse;
                @PositionMouse.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPositionMouse;
                @WASD.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @PositionMouse.started += instance.OnPositionMouse;
                @PositionMouse.performed += instance.OnPositionMouse;
                @PositionMouse.canceled += instance.OnPositionMouse;
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    public interface IKeyboardMouseActions
    {
        void OnDown(InputAction.CallbackContext context);
        void OnPositionMouse(InputAction.CallbackContext context);
        void OnWASD(InputAction.CallbackContext context);
    }
}
