// GENERATED AUTOMATICALLY FROM 'Assets/MinigameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MinigameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MinigameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MinigameInput"",
    ""maps"": [
        {
            ""name"": ""Minigame"",
            ""id"": ""0286d7e4-fd1c-4a7c-afd4-b61f3a01e3a0"",
            ""actions"": [
                {
                    ""name"": ""Left Up"",
                    ""type"": ""Button"",
                    ""id"": ""99bfeca5-3651-42f2-b4fb-0544e24c5ee4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Down"",
                    ""type"": ""Button"",
                    ""id"": ""96a24201-abd5-4aae-9040-6e010d96f18a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Up"",
                    ""type"": ""Button"",
                    ""id"": ""01f0a0d5-bb01-431b-ba9e-db1ab6e15b10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Down"",
                    ""type"": ""Button"",
                    ""id"": ""1669c518-40bc-416d-9c7c-d317b0dce10a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e2625fc-fed7-4c07-a74b-d2e57154fc55"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Left Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60ba4169-8e3d-4f09-8cbc-4cf47c0f550f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44df18b8-cbe1-43f8-ae6b-711b969c0e59"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Left Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4812d210-feed-4977-8a32-0465e739c031"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Right Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60ebfb47-e5ac-4fe1-a87d-1752adb9d998"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf2c3917-75a9-4a89-b0c3-410c4babc535"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Right Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a152cafd-b99f-4ac1-91a8-ddfaf0efe6d8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Right Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""786f49cf-3816-4755-a838-73d1bd2e4c0c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aac4485-28e3-4c9f-9c6a-c84ea8e29f0b"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Right Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca104627-185e-4e15-be56-497911463100"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Left Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""017722c1-0c3f-4ad4-99c3-481786e9af15"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8b18dee-bc34-4ea1-b3e7-c572e74628c2"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Left Up"",
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
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Minigame
        m_Minigame = asset.FindActionMap("Minigame", throwIfNotFound: true);
        m_Minigame_LeftUp = m_Minigame.FindAction("Left Up", throwIfNotFound: true);
        m_Minigame_LeftDown = m_Minigame.FindAction("Left Down", throwIfNotFound: true);
        m_Minigame_RightUp = m_Minigame.FindAction("Right Up", throwIfNotFound: true);
        m_Minigame_RightDown = m_Minigame.FindAction("Right Down", throwIfNotFound: true);
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

    // Minigame
    private readonly InputActionMap m_Minigame;
    private IMinigameActions m_MinigameActionsCallbackInterface;
    private readonly InputAction m_Minigame_LeftUp;
    private readonly InputAction m_Minigame_LeftDown;
    private readonly InputAction m_Minigame_RightUp;
    private readonly InputAction m_Minigame_RightDown;
    public struct MinigameActions
    {
        private @MinigameInput m_Wrapper;
        public MinigameActions(@MinigameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftUp => m_Wrapper.m_Minigame_LeftUp;
        public InputAction @LeftDown => m_Wrapper.m_Minigame_LeftDown;
        public InputAction @RightUp => m_Wrapper.m_Minigame_RightUp;
        public InputAction @RightDown => m_Wrapper.m_Minigame_RightDown;
        public InputActionMap Get() { return m_Wrapper.m_Minigame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MinigameActions set) { return set.Get(); }
        public void SetCallbacks(IMinigameActions instance)
        {
            if (m_Wrapper.m_MinigameActionsCallbackInterface != null)
            {
                @LeftUp.started -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftUp;
                @LeftUp.performed -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftUp;
                @LeftUp.canceled -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftUp;
                @LeftDown.started -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftDown;
                @LeftDown.performed -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftDown;
                @LeftDown.canceled -= m_Wrapper.m_MinigameActionsCallbackInterface.OnLeftDown;
                @RightUp.started -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightUp;
                @RightUp.performed -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightUp;
                @RightUp.canceled -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightUp;
                @RightDown.started -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightDown;
                @RightDown.performed -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightDown;
                @RightDown.canceled -= m_Wrapper.m_MinigameActionsCallbackInterface.OnRightDown;
            }
            m_Wrapper.m_MinigameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftUp.started += instance.OnLeftUp;
                @LeftUp.performed += instance.OnLeftUp;
                @LeftUp.canceled += instance.OnLeftUp;
                @LeftDown.started += instance.OnLeftDown;
                @LeftDown.performed += instance.OnLeftDown;
                @LeftDown.canceled += instance.OnLeftDown;
                @RightUp.started += instance.OnRightUp;
                @RightUp.performed += instance.OnRightUp;
                @RightUp.canceled += instance.OnRightUp;
                @RightDown.started += instance.OnRightDown;
                @RightDown.performed += instance.OnRightDown;
                @RightDown.canceled += instance.OnRightDown;
            }
        }
    }
    public MinigameActions @Minigame => new MinigameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    public interface IMinigameActions
    {
        void OnLeftUp(InputAction.CallbackContext context);
        void OnLeftDown(InputAction.CallbackContext context);
        void OnRightUp(InputAction.CallbackContext context);
        void OnRightDown(InputAction.CallbackContext context);
    }
}
