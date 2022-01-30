//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Declan/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""53f4e111-bb31-4df8-9967-be9250a5a928"",
            ""actions"": [
                {
                    ""name"": ""SideMovement"",
                    ""type"": ""Value"",
                    ""id"": ""1dd01bcb-d563-44b5-b71f-fd6972cbe355"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""mouseclick"",
                    ""type"": ""Value"",
                    ""id"": ""d0608919-7ac7-489e-b662-c06c2de2fb37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""mousePos"",
                    ""type"": ""Value"",
                    ""id"": ""ac69793b-f037-424d-8c50-5a44be81b3d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Arms"",
                    ""type"": ""Button"",
                    ""id"": ""1afdd172-645a-47e3-9989-2b7375854cbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""826ed2ec-b0a5-414e-8dfd-acd402184ff1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2611be0d-6731-4898-a8d8-1af0fe3f0fc6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""328ce115-a626-4719-a479-4e5ee85b1526"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""83e0f5c0-80e7-47c9-852f-556f54bb0a9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd307fd9-a22a-4306-ac6a-7b4453f7c6e3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6cbf654d-cfa3-4119-9f34-97265bdcbd46"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseclick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4a8b617-0430-433d-9076-2cd442e96e6f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""64146fb4-9ad8-41d8-81c5-8f0f4ef6200e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arms"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""db45a029-0932-4b10-b7fa-a501ab787e4c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6c718e1d-3fa9-4a98-bab9-89a22c942272"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_SideMovement = m_Default.FindAction("SideMovement", throwIfNotFound: true);
        m_Default_mouseclick = m_Default.FindAction("mouseclick", throwIfNotFound: true);
        m_Default_mousePos = m_Default.FindAction("mousePos", throwIfNotFound: true);
        m_Default_Arms = m_Default.FindAction("Arms", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_SideMovement;
    private readonly InputAction m_Default_mouseclick;
    private readonly InputAction m_Default_mousePos;
    private readonly InputAction m_Default_Arms;
    public struct DefaultActions
    {
        private @Controls m_Wrapper;
        public DefaultActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SideMovement => m_Wrapper.m_Default_SideMovement;
        public InputAction @mouseclick => m_Wrapper.m_Default_mouseclick;
        public InputAction @mousePos => m_Wrapper.m_Default_mousePos;
        public InputAction @Arms => m_Wrapper.m_Default_Arms;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @SideMovement.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSideMovement;
                @SideMovement.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSideMovement;
                @SideMovement.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSideMovement;
                @mouseclick.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseclick;
                @mouseclick.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseclick;
                @mouseclick.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMouseclick;
                @mousePos.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePos;
                @mousePos.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePos;
                @mousePos.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePos;
                @Arms.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnArms;
                @Arms.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnArms;
                @Arms.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnArms;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SideMovement.started += instance.OnSideMovement;
                @SideMovement.performed += instance.OnSideMovement;
                @SideMovement.canceled += instance.OnSideMovement;
                @mouseclick.started += instance.OnMouseclick;
                @mouseclick.performed += instance.OnMouseclick;
                @mouseclick.canceled += instance.OnMouseclick;
                @mousePos.started += instance.OnMousePos;
                @mousePos.performed += instance.OnMousePos;
                @mousePos.canceled += instance.OnMousePos;
                @Arms.started += instance.OnArms;
                @Arms.performed += instance.OnArms;
                @Arms.canceled += instance.OnArms;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnSideMovement(InputAction.CallbackContext context);
        void OnMouseclick(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnArms(InputAction.CallbackContext context);
    }
}
