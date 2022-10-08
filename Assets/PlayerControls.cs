// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""854d8615-e8e5-4a70-bb07-0cc16f2716c0"",
            ""actions"": [
                {
                    ""name"": ""Intake"",
                    ""type"": ""Button"",
                    ""id"": ""17cb7798-7a5b-4456-8f18-84470ceafa54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DriveForward"",
                    ""type"": ""Button"",
                    ""id"": ""12e1c52e-2f98-43ca-b547-b72012075913"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DriveBack"",
                    ""type"": ""Button"",
                    ""id"": ""7205feec-1fb6-4b29-95c3-dee09bfe9541"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DriveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""dfc06430-2df9-45ec-8238-58e62a399fc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DriveRight"",
                    ""type"": ""Button"",
                    ""id"": ""e3e0ee03-9283-4b0c-93f6-0c3823aa9abc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a91c5059-4e04-4ca7-b2c4-58149497cd85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""2c5f08f7-b84b-47af-890c-8cda6156311e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmExtend"",
                    ""type"": ""Button"",
                    ""id"": ""a7c595f5-c9a8-483f-b8d9-34a1f584b5d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmDecend"",
                    ""type"": ""Button"",
                    ""id"": ""14181280-ac5b-4dfa-b455-971d2bad2fa7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmRotateForward"",
                    ""type"": ""Button"",
                    ""id"": ""0f5c4bcf-1270-4b01-b165-47639d411da9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArmRotateBackward"",
                    ""type"": ""Button"",
                    ""id"": ""1f15ba29-1f80-46fc-b36d-9b1c8f0a2aee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84796515-939a-4e2c-a32e-5be53ba0785e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Intake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a5110c6-d9a1-4c18-b6e5-10abd7325ff7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Intake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6cda340-bf95-455b-9bbd-ff6c93a8afeb"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e48ec8d9-bde5-4349-ac40-ab787f7c3886"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e57f54c-196d-4c6c-8f94-81b541850e02"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2becf78d-77d9-475d-83bf-5f4848f5032c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69d86120-846d-4730-9ff0-9fbe75422c7d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81adb001-c3c2-4798-8046-2a460b3b79bc"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e598d9d-c740-4bea-aaae-46b565e0f2b9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9da18250-52a7-43af-83b5-570483f05c3e"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DriveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79123584-a5e3-41be-acb5-ddeaa81a8cf4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6702e658-ebab-4ab9-aa4e-27b7c30025c9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""438d2ed5-f7a2-47b0-afab-4881178a70ad"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fca0e83e-6382-401f-ae9a-b1597ffe702d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de40a09f-64b8-4ba9-a691-12e42a1f42fc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmExtend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d69dc20-0af2-482b-a74b-d5c3995fedb5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmDecend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96eea83f-6291-44da-8295-9f67dcc79e2f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmRotateForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4733f45-b990-46fc-84ef-95c5ee46a233"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArmRotateBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Intake = m_GamePlay.FindAction("Intake", throwIfNotFound: true);
        m_GamePlay_DriveForward = m_GamePlay.FindAction("DriveForward", throwIfNotFound: true);
        m_GamePlay_DriveBack = m_GamePlay.FindAction("DriveBack", throwIfNotFound: true);
        m_GamePlay_DriveLeft = m_GamePlay.FindAction("DriveLeft", throwIfNotFound: true);
        m_GamePlay_DriveRight = m_GamePlay.FindAction("DriveRight", throwIfNotFound: true);
        m_GamePlay_TurnLeft = m_GamePlay.FindAction("TurnLeft", throwIfNotFound: true);
        m_GamePlay_TurnRight = m_GamePlay.FindAction("TurnRight", throwIfNotFound: true);
        m_GamePlay_ArmExtend = m_GamePlay.FindAction("ArmExtend", throwIfNotFound: true);
        m_GamePlay_ArmDecend = m_GamePlay.FindAction("ArmDecend", throwIfNotFound: true);
        m_GamePlay_ArmRotateForward = m_GamePlay.FindAction("ArmRotateForward", throwIfNotFound: true);
        m_GamePlay_ArmRotateBackward = m_GamePlay.FindAction("ArmRotateBackward", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Intake;
    private readonly InputAction m_GamePlay_DriveForward;
    private readonly InputAction m_GamePlay_DriveBack;
    private readonly InputAction m_GamePlay_DriveLeft;
    private readonly InputAction m_GamePlay_DriveRight;
    private readonly InputAction m_GamePlay_TurnLeft;
    private readonly InputAction m_GamePlay_TurnRight;
    private readonly InputAction m_GamePlay_ArmExtend;
    private readonly InputAction m_GamePlay_ArmDecend;
    private readonly InputAction m_GamePlay_ArmRotateForward;
    private readonly InputAction m_GamePlay_ArmRotateBackward;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Intake => m_Wrapper.m_GamePlay_Intake;
        public InputAction @DriveForward => m_Wrapper.m_GamePlay_DriveForward;
        public InputAction @DriveBack => m_Wrapper.m_GamePlay_DriveBack;
        public InputAction @DriveLeft => m_Wrapper.m_GamePlay_DriveLeft;
        public InputAction @DriveRight => m_Wrapper.m_GamePlay_DriveRight;
        public InputAction @TurnLeft => m_Wrapper.m_GamePlay_TurnLeft;
        public InputAction @TurnRight => m_Wrapper.m_GamePlay_TurnRight;
        public InputAction @ArmExtend => m_Wrapper.m_GamePlay_ArmExtend;
        public InputAction @ArmDecend => m_Wrapper.m_GamePlay_ArmDecend;
        public InputAction @ArmRotateForward => m_Wrapper.m_GamePlay_ArmRotateForward;
        public InputAction @ArmRotateBackward => m_Wrapper.m_GamePlay_ArmRotateBackward;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Intake.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnIntake;
                @Intake.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnIntake;
                @Intake.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnIntake;
                @DriveForward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveForward;
                @DriveForward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveForward;
                @DriveForward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveForward;
                @DriveBack.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveBack;
                @DriveBack.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveBack;
                @DriveBack.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveBack;
                @DriveLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveLeft;
                @DriveLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveLeft;
                @DriveLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveLeft;
                @DriveRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveRight;
                @DriveRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveRight;
                @DriveRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnDriveRight;
                @TurnLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnLeft;
                @TurnRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnRight;
                @TurnRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnRight;
                @TurnRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTurnRight;
                @ArmExtend.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmExtend;
                @ArmExtend.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmExtend;
                @ArmExtend.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmExtend;
                @ArmDecend.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmDecend;
                @ArmDecend.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmDecend;
                @ArmDecend.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmDecend;
                @ArmRotateForward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateForward;
                @ArmRotateForward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateForward;
                @ArmRotateForward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateForward;
                @ArmRotateBackward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateBackward;
                @ArmRotateBackward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateBackward;
                @ArmRotateBackward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnArmRotateBackward;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Intake.started += instance.OnIntake;
                @Intake.performed += instance.OnIntake;
                @Intake.canceled += instance.OnIntake;
                @DriveForward.started += instance.OnDriveForward;
                @DriveForward.performed += instance.OnDriveForward;
                @DriveForward.canceled += instance.OnDriveForward;
                @DriveBack.started += instance.OnDriveBack;
                @DriveBack.performed += instance.OnDriveBack;
                @DriveBack.canceled += instance.OnDriveBack;
                @DriveLeft.started += instance.OnDriveLeft;
                @DriveLeft.performed += instance.OnDriveLeft;
                @DriveLeft.canceled += instance.OnDriveLeft;
                @DriveRight.started += instance.OnDriveRight;
                @DriveRight.performed += instance.OnDriveRight;
                @DriveRight.canceled += instance.OnDriveRight;
                @TurnLeft.started += instance.OnTurnLeft;
                @TurnLeft.performed += instance.OnTurnLeft;
                @TurnLeft.canceled += instance.OnTurnLeft;
                @TurnRight.started += instance.OnTurnRight;
                @TurnRight.performed += instance.OnTurnRight;
                @TurnRight.canceled += instance.OnTurnRight;
                @ArmExtend.started += instance.OnArmExtend;
                @ArmExtend.performed += instance.OnArmExtend;
                @ArmExtend.canceled += instance.OnArmExtend;
                @ArmDecend.started += instance.OnArmDecend;
                @ArmDecend.performed += instance.OnArmDecend;
                @ArmDecend.canceled += instance.OnArmDecend;
                @ArmRotateForward.started += instance.OnArmRotateForward;
                @ArmRotateForward.performed += instance.OnArmRotateForward;
                @ArmRotateForward.canceled += instance.OnArmRotateForward;
                @ArmRotateBackward.started += instance.OnArmRotateBackward;
                @ArmRotateBackward.performed += instance.OnArmRotateBackward;
                @ArmRotateBackward.canceled += instance.OnArmRotateBackward;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnIntake(InputAction.CallbackContext context);
        void OnDriveForward(InputAction.CallbackContext context);
        void OnDriveBack(InputAction.CallbackContext context);
        void OnDriveLeft(InputAction.CallbackContext context);
        void OnDriveRight(InputAction.CallbackContext context);
        void OnTurnLeft(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnArmExtend(InputAction.CallbackContext context);
        void OnArmDecend(InputAction.CallbackContext context);
        void OnArmRotateForward(InputAction.CallbackContext context);
        void OnArmRotateBackward(InputAction.CallbackContext context);
    }
}
