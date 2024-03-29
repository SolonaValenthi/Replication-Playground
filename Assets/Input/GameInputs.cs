//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/GameInputs.inputactions
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

public partial class @GameInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""ToTK"",
            ""id"": ""c910f736-290a-4f6c-8882-d517c2478b7a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f73c5526-beb6-425e-a603-4658beb2e457"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Toggle Ability"",
                    ""type"": ""Button"",
                    ""id"": ""7b9e63a3-707f-4abc-b82d-ff19bd6487ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use Ability"",
                    ""type"": ""Button"",
                    ""id"": ""77cc125f-c409-46c6-9533-04c0e274c568"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b2a26b4f-cdcb-4118-9940-e9974438cf90"",
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
                    ""id"": ""ed30f31e-9601-402b-9cfe-46960ed712ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a78195e1-a99e-4942-862e-654602cda5a3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""70bd81d6-a7cc-4563-a063-f178093e0354"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a6fcab34-88a1-4c8c-8ca6-5782abda6524"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ec58b5f9-125d-4b55-b61f-eeb97743e589"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0266c735-77eb-4acc-bc40-e2f516ec95b2"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65799814-f866-4600-b1a5-14c79fbe9805"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ToTK
        m_ToTK = asset.FindActionMap("ToTK", throwIfNotFound: true);
        m_ToTK_Movement = m_ToTK.FindAction("Movement", throwIfNotFound: true);
        m_ToTK_ToggleAbility = m_ToTK.FindAction("Toggle Ability", throwIfNotFound: true);
        m_ToTK_UseAbility = m_ToTK.FindAction("Use Ability", throwIfNotFound: true);
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

    // ToTK
    private readonly InputActionMap m_ToTK;
    private List<IToTKActions> m_ToTKActionsCallbackInterfaces = new List<IToTKActions>();
    private readonly InputAction m_ToTK_Movement;
    private readonly InputAction m_ToTK_ToggleAbility;
    private readonly InputAction m_ToTK_UseAbility;
    public struct ToTKActions
    {
        private @GameInputs m_Wrapper;
        public ToTKActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ToTK_Movement;
        public InputAction @ToggleAbility => m_Wrapper.m_ToTK_ToggleAbility;
        public InputAction @UseAbility => m_Wrapper.m_ToTK_UseAbility;
        public InputActionMap Get() { return m_Wrapper.m_ToTK; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ToTKActions set) { return set.Get(); }
        public void AddCallbacks(IToTKActions instance)
        {
            if (instance == null || m_Wrapper.m_ToTKActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ToTKActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @ToggleAbility.started += instance.OnToggleAbility;
            @ToggleAbility.performed += instance.OnToggleAbility;
            @ToggleAbility.canceled += instance.OnToggleAbility;
            @UseAbility.started += instance.OnUseAbility;
            @UseAbility.performed += instance.OnUseAbility;
            @UseAbility.canceled += instance.OnUseAbility;
        }

        private void UnregisterCallbacks(IToTKActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @ToggleAbility.started -= instance.OnToggleAbility;
            @ToggleAbility.performed -= instance.OnToggleAbility;
            @ToggleAbility.canceled -= instance.OnToggleAbility;
            @UseAbility.started -= instance.OnUseAbility;
            @UseAbility.performed -= instance.OnUseAbility;
            @UseAbility.canceled -= instance.OnUseAbility;
        }

        public void RemoveCallbacks(IToTKActions instance)
        {
            if (m_Wrapper.m_ToTKActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IToTKActions instance)
        {
            foreach (var item in m_Wrapper.m_ToTKActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ToTKActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ToTKActions @ToTK => new ToTKActions(this);
    public interface IToTKActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnToggleAbility(InputAction.CallbackContext context);
        void OnUseAbility(InputAction.CallbackContext context);
    }
}
