//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/UdpController/Scripts/Io/CustomActions.inputactions
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

public partial class @CustomActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomActions"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""fce0526b-f177-46c1-b52e-c6a3cd6aa9d5"",
            ""actions"": [
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""ba8ac396-8a92-4b3a-a986-24c314dd6d7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""d1226b98-dd37-49ee-9863-f48dcf886455"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""e348bc3c-30da-4553-8135-ba1cd362b814"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""b050b26d-06ff-43b1-bee4-27170dbd0bda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftStickY"",
                    ""type"": ""Value"",
                    ""id"": ""f93c4014-8016-4a5a-a616-402a2e3082e7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftStickX"",
                    ""type"": ""Value"",
                    ""id"": ""220db42a-ac5f-4b48-9c6d-2a5d9ef9484b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftStickPress"",
                    ""type"": ""Button"",
                    ""id"": ""17aac8be-18d4-491b-b7dc-66eff3817cb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightStickPress"",
                    ""type"": ""Button"",
                    ""id"": ""cbfebe0d-9bb2-4d9b-b61a-afea1cebe076"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightStickY"",
                    ""type"": ""Value"",
                    ""id"": ""a38ecca6-e914-4b02-b31e-bff965f5c7cc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightStickX"",
                    ""type"": ""Value"",
                    ""id"": ""241af2e1-d9ae-4d70-8b86-2afc33b4d6d4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DPadUp"",
                    ""type"": ""Button"",
                    ""id"": ""479a6d41-7c94-4d02-9f47-db325e5d8278"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DPadDown"",
                    ""type"": ""Button"",
                    ""id"": ""1b79fe20-0284-43aa-9f2e-154e8becf635"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DPadRight"",
                    ""type"": ""Button"",
                    ""id"": ""13adb66c-fb5b-4f5f-a4e6-87c5f420c09b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DPadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e82ce582-dc90-4620-9b0d-851ac943e40b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""81ee71cd-c889-43d7-aa3a-6df129ffcd95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""c3824ea7-f491-455e-997a-5be4a3c8b6c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""e0dc3f15-e9aa-4903-ae1c-661ed60b0ea6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""13a2ae30-8824-4ef7-a11f-19bd4783dc93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""7d8b71c6-ad95-4773-8272-267015eabe00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""204f15e3-aa85-46bb-83a7-02c4d90f267b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77609142-d989-4b81-9c37-69197853fae1"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77a9c42b-f7b2-4e1a-aaa9-eb64396541af"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e9b06ce-7f3c-4637-ad09-1d36f12b5046"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""330133ec-715f-4dc4-a826-42f7d530a888"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b78c3a9-0271-4cab-9aad-da7e8c513741"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29dd078c-adfe-49b1-b990-44435b5659db"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a29bc7ab-85dc-456e-811f-80ef191ff441"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd799a9e-a189-4875-91b6-62de758d6a08"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""067dbc20-81cf-4aeb-a13e-17b83d93617e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ef4fe43-f1ea-49f5-ab54-10a2792c7e83"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43f4821c-4674-41a7-8e45-9cce697a97a6"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b441340-b610-4be1-a4ce-8ea31a8a2a25"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b7fa9d7-81e9-4c26-aff6-2cbfdbd9ef60"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5355a662-fecc-4c3f-b6cc-0b9d0967582c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a8570d2-ff6f-416b-bcc3-f18ca3748e74"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""503736ab-0f66-4efd-a325-0c2dba961564"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fcc8716-f937-4b70-a28f-0099eaca77e2"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc36e5a5-bfa9-4e37-b72b-0215ce165b93"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da387f2f-1588-4a85-9ceb-a3cede667db6"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ec39e69-e078-4d3a-8c06-b0fd00aa2ad7"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Square = m_UI.FindAction("Square", throwIfNotFound: true);
        m_UI_Cross = m_UI.FindAction("Cross", throwIfNotFound: true);
        m_UI_Triangle = m_UI.FindAction("Triangle", throwIfNotFound: true);
        m_UI_Circle = m_UI.FindAction("Circle", throwIfNotFound: true);
        m_UI_LeftStickY = m_UI.FindAction("LeftStickY", throwIfNotFound: true);
        m_UI_LeftStickX = m_UI.FindAction("LeftStickX", throwIfNotFound: true);
        m_UI_LeftStickPress = m_UI.FindAction("LeftStickPress", throwIfNotFound: true);
        m_UI_RightStickPress = m_UI.FindAction("RightStickPress", throwIfNotFound: true);
        m_UI_RightStickY = m_UI.FindAction("RightStickY", throwIfNotFound: true);
        m_UI_RightStickX = m_UI.FindAction("RightStickX", throwIfNotFound: true);
        m_UI_DPadUp = m_UI.FindAction("DPadUp", throwIfNotFound: true);
        m_UI_DPadDown = m_UI.FindAction("DPadDown", throwIfNotFound: true);
        m_UI_DPadRight = m_UI.FindAction("DPadRight", throwIfNotFound: true);
        m_UI_DPadLeft = m_UI.FindAction("DPadLeft", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
        m_UI_L1 = m_UI.FindAction("L1", throwIfNotFound: true);
        m_UI_L2 = m_UI.FindAction("L2", throwIfNotFound: true);
        m_UI_R1 = m_UI.FindAction("R1", throwIfNotFound: true);
        m_UI_R2 = m_UI.FindAction("R2", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Square;
    private readonly InputAction m_UI_Cross;
    private readonly InputAction m_UI_Triangle;
    private readonly InputAction m_UI_Circle;
    private readonly InputAction m_UI_LeftStickY;
    private readonly InputAction m_UI_LeftStickX;
    private readonly InputAction m_UI_LeftStickPress;
    private readonly InputAction m_UI_RightStickPress;
    private readonly InputAction m_UI_RightStickY;
    private readonly InputAction m_UI_RightStickX;
    private readonly InputAction m_UI_DPadUp;
    private readonly InputAction m_UI_DPadDown;
    private readonly InputAction m_UI_DPadRight;
    private readonly InputAction m_UI_DPadLeft;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_Start;
    private readonly InputAction m_UI_L1;
    private readonly InputAction m_UI_L2;
    private readonly InputAction m_UI_R1;
    private readonly InputAction m_UI_R2;
    public struct UIActions
    {
        private @CustomActions m_Wrapper;
        public UIActions(@CustomActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Square => m_Wrapper.m_UI_Square;
        public InputAction @Cross => m_Wrapper.m_UI_Cross;
        public InputAction @Triangle => m_Wrapper.m_UI_Triangle;
        public InputAction @Circle => m_Wrapper.m_UI_Circle;
        public InputAction @LeftStickY => m_Wrapper.m_UI_LeftStickY;
        public InputAction @LeftStickX => m_Wrapper.m_UI_LeftStickX;
        public InputAction @LeftStickPress => m_Wrapper.m_UI_LeftStickPress;
        public InputAction @RightStickPress => m_Wrapper.m_UI_RightStickPress;
        public InputAction @RightStickY => m_Wrapper.m_UI_RightStickY;
        public InputAction @RightStickX => m_Wrapper.m_UI_RightStickX;
        public InputAction @DPadUp => m_Wrapper.m_UI_DPadUp;
        public InputAction @DPadDown => m_Wrapper.m_UI_DPadDown;
        public InputAction @DPadRight => m_Wrapper.m_UI_DPadRight;
        public InputAction @DPadLeft => m_Wrapper.m_UI_DPadLeft;
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputAction @L1 => m_Wrapper.m_UI_L1;
        public InputAction @L2 => m_Wrapper.m_UI_L2;
        public InputAction @R1 => m_Wrapper.m_UI_R1;
        public InputAction @R2 => m_Wrapper.m_UI_R2;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Square.started += instance.OnSquare;
            @Square.performed += instance.OnSquare;
            @Square.canceled += instance.OnSquare;
            @Cross.started += instance.OnCross;
            @Cross.performed += instance.OnCross;
            @Cross.canceled += instance.OnCross;
            @Triangle.started += instance.OnTriangle;
            @Triangle.performed += instance.OnTriangle;
            @Triangle.canceled += instance.OnTriangle;
            @Circle.started += instance.OnCircle;
            @Circle.performed += instance.OnCircle;
            @Circle.canceled += instance.OnCircle;
            @LeftStickY.started += instance.OnLeftStickY;
            @LeftStickY.performed += instance.OnLeftStickY;
            @LeftStickY.canceled += instance.OnLeftStickY;
            @LeftStickX.started += instance.OnLeftStickX;
            @LeftStickX.performed += instance.OnLeftStickX;
            @LeftStickX.canceled += instance.OnLeftStickX;
            @LeftStickPress.started += instance.OnLeftStickPress;
            @LeftStickPress.performed += instance.OnLeftStickPress;
            @LeftStickPress.canceled += instance.OnLeftStickPress;
            @RightStickPress.started += instance.OnRightStickPress;
            @RightStickPress.performed += instance.OnRightStickPress;
            @RightStickPress.canceled += instance.OnRightStickPress;
            @RightStickY.started += instance.OnRightStickY;
            @RightStickY.performed += instance.OnRightStickY;
            @RightStickY.canceled += instance.OnRightStickY;
            @RightStickX.started += instance.OnRightStickX;
            @RightStickX.performed += instance.OnRightStickX;
            @RightStickX.canceled += instance.OnRightStickX;
            @DPadUp.started += instance.OnDPadUp;
            @DPadUp.performed += instance.OnDPadUp;
            @DPadUp.canceled += instance.OnDPadUp;
            @DPadDown.started += instance.OnDPadDown;
            @DPadDown.performed += instance.OnDPadDown;
            @DPadDown.canceled += instance.OnDPadDown;
            @DPadRight.started += instance.OnDPadRight;
            @DPadRight.performed += instance.OnDPadRight;
            @DPadRight.canceled += instance.OnDPadRight;
            @DPadLeft.started += instance.OnDPadLeft;
            @DPadLeft.performed += instance.OnDPadLeft;
            @DPadLeft.canceled += instance.OnDPadLeft;
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
            @L1.started += instance.OnL1;
            @L1.performed += instance.OnL1;
            @L1.canceled += instance.OnL1;
            @L2.started += instance.OnL2;
            @L2.performed += instance.OnL2;
            @L2.canceled += instance.OnL2;
            @R1.started += instance.OnR1;
            @R1.performed += instance.OnR1;
            @R1.canceled += instance.OnR1;
            @R2.started += instance.OnR2;
            @R2.performed += instance.OnR2;
            @R2.canceled += instance.OnR2;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Square.started -= instance.OnSquare;
            @Square.performed -= instance.OnSquare;
            @Square.canceled -= instance.OnSquare;
            @Cross.started -= instance.OnCross;
            @Cross.performed -= instance.OnCross;
            @Cross.canceled -= instance.OnCross;
            @Triangle.started -= instance.OnTriangle;
            @Triangle.performed -= instance.OnTriangle;
            @Triangle.canceled -= instance.OnTriangle;
            @Circle.started -= instance.OnCircle;
            @Circle.performed -= instance.OnCircle;
            @Circle.canceled -= instance.OnCircle;
            @LeftStickY.started -= instance.OnLeftStickY;
            @LeftStickY.performed -= instance.OnLeftStickY;
            @LeftStickY.canceled -= instance.OnLeftStickY;
            @LeftStickX.started -= instance.OnLeftStickX;
            @LeftStickX.performed -= instance.OnLeftStickX;
            @LeftStickX.canceled -= instance.OnLeftStickX;
            @LeftStickPress.started -= instance.OnLeftStickPress;
            @LeftStickPress.performed -= instance.OnLeftStickPress;
            @LeftStickPress.canceled -= instance.OnLeftStickPress;
            @RightStickPress.started -= instance.OnRightStickPress;
            @RightStickPress.performed -= instance.OnRightStickPress;
            @RightStickPress.canceled -= instance.OnRightStickPress;
            @RightStickY.started -= instance.OnRightStickY;
            @RightStickY.performed -= instance.OnRightStickY;
            @RightStickY.canceled -= instance.OnRightStickY;
            @RightStickX.started -= instance.OnRightStickX;
            @RightStickX.performed -= instance.OnRightStickX;
            @RightStickX.canceled -= instance.OnRightStickX;
            @DPadUp.started -= instance.OnDPadUp;
            @DPadUp.performed -= instance.OnDPadUp;
            @DPadUp.canceled -= instance.OnDPadUp;
            @DPadDown.started -= instance.OnDPadDown;
            @DPadDown.performed -= instance.OnDPadDown;
            @DPadDown.canceled -= instance.OnDPadDown;
            @DPadRight.started -= instance.OnDPadRight;
            @DPadRight.performed -= instance.OnDPadRight;
            @DPadRight.canceled -= instance.OnDPadRight;
            @DPadLeft.started -= instance.OnDPadLeft;
            @DPadLeft.performed -= instance.OnDPadLeft;
            @DPadLeft.canceled -= instance.OnDPadLeft;
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
            @L1.started -= instance.OnL1;
            @L1.performed -= instance.OnL1;
            @L1.canceled -= instance.OnL1;
            @L2.started -= instance.OnL2;
            @L2.performed -= instance.OnL2;
            @L2.canceled -= instance.OnL2;
            @R1.started -= instance.OnR1;
            @R1.performed -= instance.OnR1;
            @R1.canceled -= instance.OnR1;
            @R2.started -= instance.OnR2;
            @R2.performed -= instance.OnR2;
            @R2.canceled -= instance.OnR2;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnSquare(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnLeftStickY(InputAction.CallbackContext context);
        void OnLeftStickX(InputAction.CallbackContext context);
        void OnLeftStickPress(InputAction.CallbackContext context);
        void OnRightStickPress(InputAction.CallbackContext context);
        void OnRightStickY(InputAction.CallbackContext context);
        void OnRightStickX(InputAction.CallbackContext context);
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
    }
}
