// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputControls/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace JLG.cooking.controls
{
    public class @InputControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": "" BasePlayer"",
            ""id"": ""f571c436-982a-4d40-b85b-aedf68fe5867"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e150bc72-0ac4-4f6f-a332-0d44e82aa7d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""a20417ed-036b-41f0-a702-8aa22a210abf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""250bd9fa-a55b-4abb-9674-52872213977c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4919dc88-d929-479b-a58c-b0e135831c1c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c300c34-aa9c-4d77-92bf-23ec27204b59"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6288f1f8-efaa-463f-b771-fd3770e7abcb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""38349fe2-6e88-42bb-a6c1-ff1417b8ac93"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""09b95169-13a0-41ce-9a1c-9f36ba8a42b5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8679f918-e7b0-4c16-ae14-452dfa163dae"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c91f5d90-85d7-4a58-9c2e-8a1b4ba5c8dc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a1f1c1b-5cb5-4ff0-8c1d-9bcf7258661b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""205f2f56-9371-46a1-a1fa-c5891945ab75"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cec3cbce-d862-4bf8-95eb-e7dd6594db62"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""23ca6595-490c-4979-8a39-8d2db22c59fe"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5a964803-1ea1-4e88-924f-cf29b6c1faae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f59dd3c2-6dc0-42c0-b747-f9af23bf9841"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardNMouse"",
            ""bindingGroup"": ""KeyboardNMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
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
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            //  BasePlayer
            m_BasePlayer = asset.FindActionMap(" BasePlayer", throwIfNotFound: true);
            m_BasePlayer_Movement = m_BasePlayer.FindAction("Movement", throwIfNotFound: true);
            m_BasePlayer_Pickup = m_BasePlayer.FindAction("Pickup", throwIfNotFound: true);
            m_BasePlayer_Interact = m_BasePlayer.FindAction("Interact", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

        //  BasePlayer
        private readonly InputActionMap m_BasePlayer;
        private IBasePlayerActions m_BasePlayerActionsCallbackInterface;
        private readonly InputAction m_BasePlayer_Movement;
        private readonly InputAction m_BasePlayer_Pickup;
        private readonly InputAction m_BasePlayer_Interact;
        public struct BasePlayerActions
        {
            private @InputControls m_Wrapper;
            public BasePlayerActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_BasePlayer_Movement;
            public InputAction @Pickup => m_Wrapper.m_BasePlayer_Pickup;
            public InputAction @Interact => m_Wrapper.m_BasePlayer_Interact;
            public InputActionMap Get() { return m_Wrapper.m_BasePlayer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BasePlayerActions set) { return set.Get(); }
            public void SetCallbacks(IBasePlayerActions instance)
            {
                if (m_Wrapper.m_BasePlayerActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnMovement;
                    @Pickup.started -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnPickup;
                    @Pickup.performed -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnPickup;
                    @Pickup.canceled -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnPickup;
                    @Interact.started -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_BasePlayerActionsCallbackInterface.OnInteract;
                }
                m_Wrapper.m_BasePlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Pickup.started += instance.OnPickup;
                    @Pickup.performed += instance.OnPickup;
                    @Pickup.canceled += instance.OnPickup;
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                }
            }
        }
        public BasePlayerActions @BasePlayer => new BasePlayerActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_Newaction;
        public struct UIActions
        {
            private @InputControls m_Wrapper;
            public UIActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public UIActions @UI => new UIActions(this);
        private int m_KeyboardNMouseSchemeIndex = -1;
        public InputControlScheme KeyboardNMouseScheme
        {
            get
            {
                if (m_KeyboardNMouseSchemeIndex == -1) m_KeyboardNMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardNMouse");
                return asset.controlSchemes[m_KeyboardNMouseSchemeIndex];
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
        public interface IBasePlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnPickup(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
