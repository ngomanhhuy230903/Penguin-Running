//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Inputs/RunnerInputAction.inputactions
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

public partial class @RunnerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RunnerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RunnerInputAction"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""41da1e9e-ee10-4bff-857b-c13ba3a0fc51"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""9f7dd9f5-0c72-4942-a35f-0de090902e8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""05e5fbef-cbc7-4de9-b0c9-ef8c1a1ebe6a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StartDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4b738db1-a9d3-4664-a478-a4a6c91d8220"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EndDrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5da42e64-88b1-4fed-8c14-0972fc321418"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3b55c15-e0e8-41a7-a6f9-55f95010e0b8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f1eecbf-93da-48c4-8a9f-438cd3d3bcde"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Moblie"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64366186-c0e5-4287-abb2-344ce0dd6539"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c9a3306-84a6-45f2-8976-a4de0f967f00"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Moblie"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92be752a-a9fa-4c02-b8d3-5d428a27935e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07ecd3d6-7838-495e-a0f3-604afab3de28"",
                    ""path"": ""<Touchscreen>/touch*/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Moblie"",
                    ""action"": ""StartDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9da997c9-1a56-4c67-a3cd-2c45bc916424"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bc73e21-4534-4ac6-b200-d06c9cadf109"",
                    ""path"": ""<Touchscreen>/touch*/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Moblie"",
                    ""action"": ""EndDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Computer"",
            ""bindingGroup"": ""Computer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>/{Back}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>/{Back}"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Moblie"",
            ""bindingGroup"": ""Moblie"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>/{Back}"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Tap = m_GamePlay.FindAction("Tap", throwIfNotFound: true);
        m_GamePlay_TouchPosition = m_GamePlay.FindAction("TouchPosition", throwIfNotFound: true);
        m_GamePlay_StartDrag = m_GamePlay.FindAction("StartDrag", throwIfNotFound: true);
        m_GamePlay_EndDrag = m_GamePlay.FindAction("EndDrag", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private List<IGamePlayActions> m_GamePlayActionsCallbackInterfaces = new List<IGamePlayActions>();
    private readonly InputAction m_GamePlay_Tap;
    private readonly InputAction m_GamePlay_TouchPosition;
    private readonly InputAction m_GamePlay_StartDrag;
    private readonly InputAction m_GamePlay_EndDrag;
    public struct GamePlayActions
    {
        private @RunnerInputAction m_Wrapper;
        public GamePlayActions(@RunnerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_GamePlay_Tap;
        public InputAction @TouchPosition => m_Wrapper.m_GamePlay_TouchPosition;
        public InputAction @StartDrag => m_Wrapper.m_GamePlay_StartDrag;
        public InputAction @EndDrag => m_Wrapper.m_GamePlay_EndDrag;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Add(instance);
            @Tap.started += instance.OnTap;
            @Tap.performed += instance.OnTap;
            @Tap.canceled += instance.OnTap;
            @TouchPosition.started += instance.OnTouchPosition;
            @TouchPosition.performed += instance.OnTouchPosition;
            @TouchPosition.canceled += instance.OnTouchPosition;
            @StartDrag.started += instance.OnStartDrag;
            @StartDrag.performed += instance.OnStartDrag;
            @StartDrag.canceled += instance.OnStartDrag;
            @EndDrag.started += instance.OnEndDrag;
            @EndDrag.performed += instance.OnEndDrag;
            @EndDrag.canceled += instance.OnEndDrag;
        }

        private void UnregisterCallbacks(IGamePlayActions instance)
        {
            @Tap.started -= instance.OnTap;
            @Tap.performed -= instance.OnTap;
            @Tap.canceled -= instance.OnTap;
            @TouchPosition.started -= instance.OnTouchPosition;
            @TouchPosition.performed -= instance.OnTouchPosition;
            @TouchPosition.canceled -= instance.OnTouchPosition;
            @StartDrag.started -= instance.OnStartDrag;
            @StartDrag.performed -= instance.OnStartDrag;
            @StartDrag.canceled -= instance.OnStartDrag;
            @EndDrag.started -= instance.OnEndDrag;
            @EndDrag.performed -= instance.OnEndDrag;
            @EndDrag.canceled -= instance.OnEndDrag;
        }

        public void RemoveCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_ComputerSchemeIndex = -1;
    public InputControlScheme ComputerScheme
    {
        get
        {
            if (m_ComputerSchemeIndex == -1) m_ComputerSchemeIndex = asset.FindControlSchemeIndex("Computer");
            return asset.controlSchemes[m_ComputerSchemeIndex];
        }
    }
    private int m_MoblieSchemeIndex = -1;
    public InputControlScheme MoblieScheme
    {
        get
        {
            if (m_MoblieSchemeIndex == -1) m_MoblieSchemeIndex = asset.FindControlSchemeIndex("Moblie");
            return asset.controlSchemes[m_MoblieSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnTap(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnStartDrag(InputAction.CallbackContext context);
        void OnEndDrag(InputAction.CallbackContext context);
    }
}