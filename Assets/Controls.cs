// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerMovements"",
            ""id"": ""bd05aec3-0f3f-40ae-b921-90a57ce4819d"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""bc30fd83-6717-47e7-b18f-d0e47ebb5568"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""0789fe89-cf6f-4a1e-a4f7-82540278a2b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""550a18e5-6fa1-4fe6-b4c6-0a83cf93857c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""82cd06e9-d1a9-4b60-8277-d86ac8d34cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b3484e0-a8e6-4307-a59b-0b955d15c41a"",
                    ""path"": ""<Keyboard>/#(Q)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""140ca2c1-3dc1-439c-86ab-a674148d5a60"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dd95c69-7daa-4f81-8973-a3f158ec0e69"",
                    ""path"": ""<Keyboard>/#(Z)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ed1774c-1c38-40cd-b5cc-71de7b18d545"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMaterials"",
            ""id"": ""1a30a356-75a7-4b49-87b8-eae63667cc9f"",
            ""actions"": [
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4e6d36b9-26a2-4225-b6d3-a7c685751120"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6f4e1842-b670-40af-a2f7-5e6a30a66456"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovements
        m_PlayerMovements = asset.FindActionMap("PlayerMovements", throwIfNotFound: true);
        m_PlayerMovements_Left = m_PlayerMovements.FindAction("Left", throwIfNotFound: true);
        m_PlayerMovements_Right = m_PlayerMovements.FindAction("Right", throwIfNotFound: true);
        m_PlayerMovements_Up = m_PlayerMovements.FindAction("Up", throwIfNotFound: true);
        m_PlayerMovements_Down = m_PlayerMovements.FindAction("Down", throwIfNotFound: true);
        // PlayerMaterials
        m_PlayerMaterials = asset.FindActionMap("PlayerMaterials", throwIfNotFound: true);
        m_PlayerMaterials_Scroll = m_PlayerMaterials.FindAction("Scroll", throwIfNotFound: true);
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

    // PlayerMovements
    private readonly InputActionMap m_PlayerMovements;
    private IPlayerMovementsActions m_PlayerMovementsActionsCallbackInterface;
    private readonly InputAction m_PlayerMovements_Left;
    private readonly InputAction m_PlayerMovements_Right;
    private readonly InputAction m_PlayerMovements_Up;
    private readonly InputAction m_PlayerMovements_Down;
    public struct PlayerMovementsActions
    {
        private @Controls m_Wrapper;
        public PlayerMovementsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_PlayerMovements_Left;
        public InputAction @Right => m_Wrapper.m_PlayerMovements_Right;
        public InputAction @Up => m_Wrapper.m_PlayerMovements_Up;
        public InputAction @Down => m_Wrapper.m_PlayerMovements_Down;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementsActions instance)
        {
            if (m_Wrapper.m_PlayerMovementsActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRight;
                @Up.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_PlayerMovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public PlayerMovementsActions @PlayerMovements => new PlayerMovementsActions(this);

    // PlayerMaterials
    private readonly InputActionMap m_PlayerMaterials;
    private IPlayerMaterialsActions m_PlayerMaterialsActionsCallbackInterface;
    private readonly InputAction m_PlayerMaterials_Scroll;
    public struct PlayerMaterialsActions
    {
        private @Controls m_Wrapper;
        public PlayerMaterialsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scroll => m_Wrapper.m_PlayerMaterials_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMaterials; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMaterialsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMaterialsActions instance)
        {
            if (m_Wrapper.m_PlayerMaterialsActionsCallbackInterface != null)
            {
                @Scroll.started -= m_Wrapper.m_PlayerMaterialsActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_PlayerMaterialsActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_PlayerMaterialsActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_PlayerMaterialsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public PlayerMaterialsActions @PlayerMaterials => new PlayerMaterialsActions(this);
    public interface IPlayerMovementsActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
    public interface IPlayerMaterialsActions
    {
        void OnScroll(InputAction.CallbackContext context);
    }
}