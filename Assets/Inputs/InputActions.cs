// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bd6974a5-90e9-48d7-9f84-b672ad5c5009"",
            ""actions"": [
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""74b6ab42-f94f-45cd-8d4b-75e197334f9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""814034d4-7e55-46cb-9e89-797c6c54bf2c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""4a4eb53a-68e1-4958-a39d-f6a8536d3c71"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""7068371d-6c98-49e8-84b4-b52353d595c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09e535c6-ea11-4559-a303-1a4586656f6e"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""218b408f-2038-4885-8d8c-6fbe5643f76e"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""725e92e2-4a6a-42d2-adb1-af3dcffa121f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4f1166e-d2c2-4881-a855-ecaeb3ed3531"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_R1 = m_Player.FindAction("R1", throwIfNotFound: true);
        m_Player_R2 = m_Player.FindAction("R2", throwIfNotFound: true);
        m_Player_L1 = m_Player.FindAction("L1", throwIfNotFound: true);
        m_Player_L2 = m_Player.FindAction("L2", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_R1;
    private readonly InputAction m_Player_R2;
    private readonly InputAction m_Player_L1;
    private readonly InputAction m_Player_L2;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @R1 => m_Wrapper.m_Player_R1;
        public InputAction @R2 => m_Wrapper.m_Player_R2;
        public InputAction @L1 => m_Wrapper.m_Player_L1;
        public InputAction @L2 => m_Wrapper.m_Player_L2;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @R1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR2;
                @L1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnL2;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
    }
}
