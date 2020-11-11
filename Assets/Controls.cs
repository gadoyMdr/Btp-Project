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
        },
        {
            ""name"": ""UI"",
            ""id"": ""0b8bbf94-660e-4d6e-a5cb-2fede9805895"",
            ""actions"": [
                {
                    ""name"": ""TogglePause"",
                    ""type"": ""Button"",
                    ""id"": ""bd17b5d6-3968-4fb9-9289-b3eab2b24ea2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67c9c69a-8213-4b03-b5ec-62091d26c1b4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""3a8836df-db73-4e21-91c2-de1de3dd1aa6"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""276a739e-6794-45e4-89d0-dbfb9f65fc14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d7d445a-5a53-45fb-979b-813a46893088"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerInteraction"",
            ""id"": ""26e09ce1-9fce-4c1d-9320-5a7fc5228513"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""e5e42ecb-91bb-4485-8acc-6548092bd490"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d68271ef-c367-4b0b-98a8-20b6b7629a1d"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
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
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_TogglePause = m_UI.FindAction("TogglePause", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_LeftClick = m_Mouse.FindAction("LeftClick", throwIfNotFound: true);
        // PlayerInteraction
        m_PlayerInteraction = asset.FindActionMap("PlayerInteraction", throwIfNotFound: true);
        m_PlayerInteraction_Grab = m_PlayerInteraction.FindAction("Grab", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_TogglePause;
    public struct UIActions
    {
        private @Controls m_Wrapper;
        public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TogglePause => m_Wrapper.m_UI_TogglePause;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @TogglePause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTogglePause;
                @TogglePause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTogglePause;
                @TogglePause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTogglePause;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TogglePause.started += instance.OnTogglePause;
                @TogglePause.performed += instance.OnTogglePause;
                @TogglePause.canceled += instance.OnTogglePause;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_LeftClick;
    public struct MouseActions
    {
        private @Controls m_Wrapper;
        public MouseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Mouse_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // PlayerInteraction
    private readonly InputActionMap m_PlayerInteraction;
    private IPlayerInteractionActions m_PlayerInteractionActionsCallbackInterface;
    private readonly InputAction m_PlayerInteraction_Grab;
    public struct PlayerInteractionActions
    {
        private @Controls m_Wrapper;
        public PlayerInteractionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_PlayerInteraction_Grab;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInteraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInteractionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInteractionActions instance)
        {
            if (m_Wrapper.m_PlayerInteractionActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_PlayerInteractionActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_PlayerInteractionActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_PlayerInteractionActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_PlayerInteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public PlayerInteractionActions @PlayerInteraction => new PlayerInteractionActions(this);
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
    public interface IUIActions
    {
        void OnTogglePause(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
    }
    public interface IPlayerInteractionActions
    {
        void OnGrab(InputAction.CallbackContext context);
    }
}
