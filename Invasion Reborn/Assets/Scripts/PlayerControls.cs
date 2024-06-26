//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""ac3ff233-1d25-48e8-b559-ac516a5e4ab6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f4234d9f-af9d-4f92-9741-e82907667513"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""f57e1372-4327-406a-8255-2de52a942ffe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""46493dcb-a6e8-4e74-b68b-4fb68bc5ad05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""41bcaf5c-273a-480c-b165-190be87a8f7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slow"",
                    ""type"": ""Value"",
                    ""id"": ""42a96f35-e896-4f57-8627-3da8916d3022"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Build1"",
                    ""type"": ""Button"",
                    ""id"": ""87874aed-139e-48b4-b8b3-bd394abf01c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Build2"",
                    ""type"": ""Button"",
                    ""id"": ""ee574a98-8e07-4a1a-8f72-d3bd11c9cdd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Build3"",
                    ""type"": ""Button"",
                    ""id"": ""faec8b6f-f07d-49b0-ba47-4b92fc2fd483"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Build4"",
                    ""type"": ""Button"",
                    ""id"": ""14113088-829b-434c-83de-05ad6a8c3a62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Build"",
                    ""type"": ""Button"",
                    ""id"": ""a97a5fdc-c6c9-4df5-946e-5f93cd74d59d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""12445840-99e9-47db-b6b0-1169840eb43b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""d257cf3b-80b3-437b-b5b9-f60a2f297dc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""75d4268e-f7ae-4204-8fed-e44b088b470d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""893612ab-c21d-4f47-aea9-c6e9437d0b06"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e2a767f7-7a9a-4be9-900c-a3a2ed50c82f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""db18dc8d-0c1c-4e7a-befb-8407633ed8fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d04b930f-32a7-4692-8877-55535f2a0149"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cb68f0ac-53d2-4e11-a1e2-cc5b43ea16ac"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4f796cfc-1269-4304-8258-8658322931b4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a9dca59-aeda-4b65-b088-f1df551a0b54"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90326369-db76-424a-bb14-03ebc1318950"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""955530e1-d6ce-4653-8a88-c386e8c84e84"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6675717-82a8-4c9e-bbab-30a6b40bae21"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50778d25-9dd1-4d92-98b3-3c45fb430727"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5e3b143-b21c-41d8-9d2f-1563f89e3807"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Build"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91b2025e-e8db-4aa7-bba8-db7a28178e15"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b52df205-ee60-4749-8bab-c69ea40eed9e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e9cdc0a-e70d-4e30-b216-fa4c98b20a21"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20ad182f-14ef-47e2-bc82-9d442cf20e8c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cb61dfa-f5b3-48fb-836b-1c9548abea91"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bdb5f95-f1f0-4e0b-bad6-c4fc4268f152"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Down = m_Gameplay.FindAction("Down", throwIfNotFound: true);
        m_Gameplay_Up = m_Gameplay.FindAction("Up", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Slow = m_Gameplay.FindAction("Slow", throwIfNotFound: true);
        m_Gameplay_Build1 = m_Gameplay.FindAction("Build1", throwIfNotFound: true);
        m_Gameplay_Build2 = m_Gameplay.FindAction("Build2", throwIfNotFound: true);
        m_Gameplay_Build3 = m_Gameplay.FindAction("Build3", throwIfNotFound: true);
        m_Gameplay_Build4 = m_Gameplay.FindAction("Build4", throwIfNotFound: true);
        m_Gameplay_Build = m_Gameplay.FindAction("Build", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Enter = m_Gameplay.FindAction("Enter", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Down;
    private readonly InputAction m_Gameplay_Up;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Slow;
    private readonly InputAction m_Gameplay_Build1;
    private readonly InputAction m_Gameplay_Build2;
    private readonly InputAction m_Gameplay_Build3;
    private readonly InputAction m_Gameplay_Build4;
    private readonly InputAction m_Gameplay_Build;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Enter;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Down => m_Wrapper.m_Gameplay_Down;
        public InputAction @Up => m_Wrapper.m_Gameplay_Up;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Slow => m_Wrapper.m_Gameplay_Slow;
        public InputAction @Build1 => m_Wrapper.m_Gameplay_Build1;
        public InputAction @Build2 => m_Wrapper.m_Gameplay_Build2;
        public InputAction @Build3 => m_Wrapper.m_Gameplay_Build3;
        public InputAction @Build4 => m_Wrapper.m_Gameplay_Build4;
        public InputAction @Build => m_Wrapper.m_Gameplay_Build;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Enter => m_Wrapper.m_Gameplay_Enter;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Slow.started += instance.OnSlow;
            @Slow.performed += instance.OnSlow;
            @Slow.canceled += instance.OnSlow;
            @Build1.started += instance.OnBuild1;
            @Build1.performed += instance.OnBuild1;
            @Build1.canceled += instance.OnBuild1;
            @Build2.started += instance.OnBuild2;
            @Build2.performed += instance.OnBuild2;
            @Build2.canceled += instance.OnBuild2;
            @Build3.started += instance.OnBuild3;
            @Build3.performed += instance.OnBuild3;
            @Build3.canceled += instance.OnBuild3;
            @Build4.started += instance.OnBuild4;
            @Build4.performed += instance.OnBuild4;
            @Build4.canceled += instance.OnBuild4;
            @Build.started += instance.OnBuild;
            @Build.performed += instance.OnBuild;
            @Build.canceled += instance.OnBuild;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Enter.started += instance.OnEnter;
            @Enter.performed += instance.OnEnter;
            @Enter.canceled += instance.OnEnter;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Slow.started -= instance.OnSlow;
            @Slow.performed -= instance.OnSlow;
            @Slow.canceled -= instance.OnSlow;
            @Build1.started -= instance.OnBuild1;
            @Build1.performed -= instance.OnBuild1;
            @Build1.canceled -= instance.OnBuild1;
            @Build2.started -= instance.OnBuild2;
            @Build2.performed -= instance.OnBuild2;
            @Build2.canceled -= instance.OnBuild2;
            @Build3.started -= instance.OnBuild3;
            @Build3.performed -= instance.OnBuild3;
            @Build3.canceled -= instance.OnBuild3;
            @Build4.started -= instance.OnBuild4;
            @Build4.performed -= instance.OnBuild4;
            @Build4.canceled -= instance.OnBuild4;
            @Build.started -= instance.OnBuild;
            @Build.performed -= instance.OnBuild;
            @Build.canceled -= instance.OnBuild;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Enter.started -= instance.OnEnter;
            @Enter.performed -= instance.OnEnter;
            @Enter.canceled -= instance.OnEnter;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSlow(InputAction.CallbackContext context);
        void OnBuild1(InputAction.CallbackContext context);
        void OnBuild2(InputAction.CallbackContext context);
        void OnBuild3(InputAction.CallbackContext context);
        void OnBuild4(InputAction.CallbackContext context);
        void OnBuild(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
}
