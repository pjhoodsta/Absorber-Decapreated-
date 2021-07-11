// GENERATED AUTOMATICALLY FROM 'Assets/Resources/PlayerInputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Game.CustomInput
{
    public class @PlayerUnityInputAsset : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerUnityInputAsset()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputController"",
    ""maps"": [
        {
            ""name"": ""Player0Combat"",
            ""id"": ""1308c960-c7fc-4b54-9ec4-1cc291953cc3"",
            ""actions"": [
                {
                    ""name"": ""PrimaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""9e7eb1aa-0b54-43c7-aa26-5ced72c83405"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a9995963-54e7-4c6c-917d-42dc31fb3835"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7afbe1d1-9af4-49a9-af2a-8030c68e5e08"",
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
                    ""id"": ""dbbf9401-64d2-4784-9341-d6d06be833b1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d327a70-d903-43cc-beef-16b4277845e8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6141700f-300b-4800-82b0-5534a8b49aa3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7b3bb711-ee76-4c9c-8daa-2cd526b98492"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""58001390-7a3c-4ae6-9d6a-4fb52f0991fe"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboard"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Master"",
            ""bindingGroup"": ""Master"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""DefaultKeyboard"",
            ""bindingGroup"": ""DefaultKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player0Combat
            m_Player0Combat = asset.FindActionMap("Player0Combat", throwIfNotFound: true);
            m_Player0Combat_PrimaryAttack = m_Player0Combat.FindAction("PrimaryAttack", throwIfNotFound: true);
            m_Player0Combat_Movement = m_Player0Combat.FindAction("Movement", throwIfNotFound: true);
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

        // Player0Combat
        private readonly InputActionMap m_Player0Combat;
        private IPlayer0CombatActions m_Player0CombatActionsCallbackInterface;
        private readonly InputAction m_Player0Combat_PrimaryAttack;
        private readonly InputAction m_Player0Combat_Movement;
        public struct Player0CombatActions
        {
            private @PlayerUnityInputAsset m_Wrapper;
            public Player0CombatActions(@PlayerUnityInputAsset wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryAttack => m_Wrapper.m_Player0Combat_PrimaryAttack;
            public InputAction @Movement => m_Wrapper.m_Player0Combat_Movement;
            public InputActionMap Get() { return m_Wrapper.m_Player0Combat; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Player0CombatActions set) { return set.Get(); }
            public void SetCallbacks(IPlayer0CombatActions instance)
            {
                if (m_Wrapper.m_Player0CombatActionsCallbackInterface != null)
                {
                    @PrimaryAttack.started -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnPrimaryAttack;
                    @PrimaryAttack.performed -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnPrimaryAttack;
                    @PrimaryAttack.canceled -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnPrimaryAttack;
                    @Movement.started -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_Player0CombatActionsCallbackInterface.OnMovement;
                }
                m_Wrapper.m_Player0CombatActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PrimaryAttack.started += instance.OnPrimaryAttack;
                    @PrimaryAttack.performed += instance.OnPrimaryAttack;
                    @PrimaryAttack.canceled += instance.OnPrimaryAttack;
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                }
            }
        }
        public Player0CombatActions @Player0Combat => new Player0CombatActions(this);
        private int m_MasterSchemeIndex = -1;
        public InputControlScheme MasterScheme
        {
            get
            {
                if (m_MasterSchemeIndex == -1) m_MasterSchemeIndex = asset.FindControlSchemeIndex("Master");
                return asset.controlSchemes[m_MasterSchemeIndex];
            }
        }
        private int m_DefaultKeyboardSchemeIndex = -1;
        public InputControlScheme DefaultKeyboardScheme
        {
            get
            {
                if (m_DefaultKeyboardSchemeIndex == -1) m_DefaultKeyboardSchemeIndex = asset.FindControlSchemeIndex("DefaultKeyboard");
                return asset.controlSchemes[m_DefaultKeyboardSchemeIndex];
            }
        }
        public interface IPlayer0CombatActions
        {
            void OnPrimaryAttack(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
        }
    }
}
