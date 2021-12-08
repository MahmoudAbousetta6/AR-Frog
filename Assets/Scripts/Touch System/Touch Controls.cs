// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Touch System/Touch Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Touch Controls"",
    ""maps"": [
        {
            ""name"": ""SingleTap"",
            ""id"": ""de551c8e-9791-4394-9969-88ddfb44eec5"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Value"",
                    ""id"": ""f863b9f9-5363-46f9-ac07-c8c905c87263"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d6c76eb-7bf2-4846-b6ef-7df1dbc0d57b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drag"",
            ""id"": ""b4d0501a-8390-4b58-bb06-4e20575cb3f3"",
            ""actions"": [
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Button"",
                    ""id"": ""2cf0585c-a0eb-43e4-87db-2a201705678f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""e948031f-012a-45c9-a05a-b80d014fd2c1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b63467f-2cc9-4302-b7da-213d9a7e4705"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def0fa40-f433-41c6-9e67-a90745067a30"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Rotate"",
            ""id"": ""1726b7cd-d12c-4cc9-bdf7-a1157e3bf6a7"",
            ""actions"": [
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Value"",
                    ""id"": ""b1ec2e79-275e-4ee6-80d4-7227957d8c40"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""507746ad-1836-4dca-89a5-234209fe918a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d23bdfe-63e5-4e65-b928-0d477a7ad5a8"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1256b889-625e-42a0-b318-fbee5d5a5ea8"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Scale"",
            ""id"": ""23784e3e-9e95-483f-ab70-1ecc61342a97"",
            ""actions"": [
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Button"",
                    ""id"": ""bb71f44a-b5e3-4a0e-b93a-8b24882b94ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""b6ca9dba-f379-498f-9af9-afedc34813bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""3209471b-011d-4866-a3f9-35a395c4339d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""523a9424-72bf-403f-8e9f-fc5476e43289"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09708404-3716-4b44-a5a1-0ecadf2bb7e8"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74ab461e-9a6f-43f6-805a-8ed07522cfdb"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SingleTap
        m_SingleTap = asset.FindActionMap("SingleTap", throwIfNotFound: true);
        m_SingleTap_Tap = m_SingleTap.FindAction("Tap", throwIfNotFound: true);
        // Drag
        m_Drag = asset.FindActionMap("Drag", throwIfNotFound: true);
        m_Drag_SecondaryTouchDetect = m_Drag.FindAction("Secondary Touch Detect", throwIfNotFound: true);
        m_Drag_PrimaryFingerPosition = m_Drag.FindAction("Primary Finger Position", throwIfNotFound: true);
        // Rotate
        m_Rotate = asset.FindActionMap("Rotate", throwIfNotFound: true);
        m_Rotate_SecondaryTouchDetect = m_Rotate.FindAction("Secondary Touch Detect", throwIfNotFound: true);
        m_Rotate_PrimaryFingerPosition = m_Rotate.FindAction("Primary Finger Position", throwIfNotFound: true);
        // Scale
        m_Scale = asset.FindActionMap("Scale", throwIfNotFound: true);
        m_Scale_SecondaryTouchDetect = m_Scale.FindAction("Secondary Touch Detect", throwIfNotFound: true);
        m_Scale_PrimaryFingerPosition = m_Scale.FindAction("Primary Finger Position", throwIfNotFound: true);
        m_Scale_SecondaryFingerPosition = m_Scale.FindAction("Secondary Finger Position", throwIfNotFound: true);
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

    // SingleTap
    private readonly InputActionMap m_SingleTap;
    private ISingleTapActions m_SingleTapActionsCallbackInterface;
    private readonly InputAction m_SingleTap_Tap;
    public struct SingleTapActions
    {
        private @TouchControls m_Wrapper;
        public SingleTapActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_SingleTap_Tap;
        public InputActionMap Get() { return m_Wrapper.m_SingleTap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SingleTapActions set) { return set.Get(); }
        public void SetCallbacks(ISingleTapActions instance)
        {
            if (m_Wrapper.m_SingleTapActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_SingleTapActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_SingleTapActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_SingleTapActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_SingleTapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public SingleTapActions @SingleTap => new SingleTapActions(this);

    // Drag
    private readonly InputActionMap m_Drag;
    private IDragActions m_DragActionsCallbackInterface;
    private readonly InputAction m_Drag_SecondaryTouchDetect;
    private readonly InputAction m_Drag_PrimaryFingerPosition;
    public struct DragActions
    {
        private @TouchControls m_Wrapper;
        public DragActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Drag_SecondaryTouchDetect;
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Drag_PrimaryFingerPosition;
        public InputActionMap Get() { return m_Wrapper.m_Drag; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DragActions set) { return set.Get(); }
        public void SetCallbacks(IDragActions instance)
        {
            if (m_Wrapper.m_DragActionsCallbackInterface != null)
            {
                @SecondaryTouchDetect.started -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
            }
            m_Wrapper.m_DragActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
            }
        }
    }
    public DragActions @Drag => new DragActions(this);

    // Rotate
    private readonly InputActionMap m_Rotate;
    private IRotateActions m_RotateActionsCallbackInterface;
    private readonly InputAction m_Rotate_SecondaryTouchDetect;
    private readonly InputAction m_Rotate_PrimaryFingerPosition;
    public struct RotateActions
    {
        private @TouchControls m_Wrapper;
        public RotateActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Rotate_SecondaryTouchDetect;
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Rotate_PrimaryFingerPosition;
        public InputActionMap Get() { return m_Wrapper.m_Rotate; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotateActions set) { return set.Get(); }
        public void SetCallbacks(IRotateActions instance)
        {
            if (m_Wrapper.m_RotateActionsCallbackInterface != null)
            {
                @SecondaryTouchDetect.started -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
            }
            m_Wrapper.m_RotateActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
            }
        }
    }
    public RotateActions @Rotate => new RotateActions(this);

    // Scale
    private readonly InputActionMap m_Scale;
    private IScaleActions m_ScaleActionsCallbackInterface;
    private readonly InputAction m_Scale_SecondaryTouchDetect;
    private readonly InputAction m_Scale_PrimaryFingerPosition;
    private readonly InputAction m_Scale_SecondaryFingerPosition;
    public struct ScaleActions
    {
        private @TouchControls m_Wrapper;
        public ScaleActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Scale_SecondaryTouchDetect;
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Scale_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Scale_SecondaryFingerPosition;
        public InputActionMap Get() { return m_Wrapper.m_Scale; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScaleActions set) { return set.Get(); }
        public void SetCallbacks(IScaleActions instance)
        {
            if (m_Wrapper.m_ScaleActionsCallbackInterface != null)
            {
                @SecondaryTouchDetect.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
            }
            m_Wrapper.m_ScaleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
            }
        }
    }
    public ScaleActions @Scale => new ScaleActions(this);
    public interface ISingleTapActions
    {
        void OnTap(InputAction.CallbackContext context);
    }
    public interface IDragActions
    {
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
    }
    public interface IRotateActions
    {
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
    }
    public interface IScaleActions
    {
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
    }
}
