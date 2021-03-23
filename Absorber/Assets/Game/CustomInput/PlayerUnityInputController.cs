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
            ""name"": ""Player0Gameplay"",
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
                    ""name"": ""SecondaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""cea056b8-c5ec-443c-8c06-17e12ef24cb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""478f5e8c-f5fb-404c-ab92-6aa1446b680f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""e6ca8b1b-888b-4933-9866-5d58b0367347"",
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
                    ""interactions"": ""Tap,MultiTap,Hold""
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""8905873a-2aa1-4dd1-a303-b0f5835b8be0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimarySpecial"",
                    ""type"": ""Button"",
                    ""id"": ""72785548-7f73-43c3-b2a0-64a68cfb1d73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondarySpecial"",
                    ""type"": ""Button"",
                    ""id"": ""0a53a934-2a2b-4699-af2a-be60161bf676"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TertiarySpecial"",
                    ""type"": ""Button"",
                    ""id"": ""10ae61bd-4845-46af-85bf-a8770893bb3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Selection"",
                    ""type"": ""Value"",
                    ""id"": ""a3a123d4-c129-418a-9f3c-1ac51f6d9f35"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b94d383-ad99-4799-8dcb-67b86a7acc54"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa316327-9020-42b9-a3b7-66c979c633d1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6878f9bc-2b57-4aaf-986e-de7ee64303c8"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0402ff90-d47b-437b-8e32-1ebb93c1e8ff"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fea589bf-f316-4c61-ad0f-8fb6c5dfc580"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12bf06ee-0a25-4caa-b395-d47c8f1287be"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondaryAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a059d55-ebd4-4272-b7e7-1ec0cc24570f"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""047a202b-d141-4122-93ab-e0b854ffb32d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0191d2e9-696f-48f7-9b48-749e09c83b33"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c45d30f-1f7b-451a-be6b-6efa3ec5fcb6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2c77f29-d063-4a0c-b173-4dc8b24ec606"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9613683-6114-4ce6-9ecf-197a521a22be"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7f687c9d-69be-4cee-81fe-be3b3a5cf5f6"",
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
                    ""id"": ""e3710eed-bb53-4145-9975-2a8fd0b084af"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b98fa3f4-0f51-46b4-a3e9-5e05d885e794"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e242c9e-c6a8-4704-856a-2cb68df41b1c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69e4d36f-23cf-4264-9d65-6de003301c55"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""735b5446-7a80-493d-9a20-8c378d215a7f"",
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
                    ""id"": ""7524f456-d641-4df3-8b0b-c5d8c98e4ddc"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6304c555-a468-404c-921a-c6bdefbd9ea9"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0f36f565-685f-4958-af3b-0c8327beb3e6"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""088860c6-5a7b-46c8-a244-2c82b1e17257"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""40b1c56d-2486-4b5c-ad28-e4a43ce2cc79"",
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
                    ""id"": ""763be889-b836-46e6-beea-52d2a4511d76"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1abf2f7d-b7c6-4c05-bdcf-6487a9843967"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f24cb5e9-f61b-43c9-9adc-1249ff7cb2cc"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7ad89abe-b79a-452f-874d-c90c9a40bb39"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8437273f-c56a-4736-8245-72308cf2c71b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68dea5b8-5ebb-4912-bb68-b8422e9e07a7"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a28223c-c299-40f7-83f8-10a100493c4d"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9930cc20-b7d3-48b2-83cf-f5f473bbd3af"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb061647-8c13-4361-b0d0-44936412201d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cacc6fe-f379-4a5e-b687-b2834e952e59"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""PrimarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6fc7d6e6-41a7-4271-8bd6-50e2a209406f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2d20dce-2953-4995-87a1-3d80d08c4161"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb7af0b6-ee52-4474-9338-76682776abdd"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""SecondarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c714470a-763d-4659-bc6d-8dfae0f54a9a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""TertiarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a71815d-3f5b-4e26-a7c3-9f93adf43206"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""TertiarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4f28dee-dfbc-446e-ad00-d2fc936e8ca3"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""TertiarySpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""90dd3860-3be7-4631-87ae-7389345cb38e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8701091a-72b4-4379-88f6-cc8ed8d1c833"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""29e52351-3136-42bd-b1fd-42aa3cf2df38"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11ed7fd7-d705-4525-86dd-c4882a66b70c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""018d9b46-8b6b-40b6-9bd2-90c0fd2e1ff4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a7c64ed3-4307-4106-a15a-c142a3f0dec7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e91c9e9a-dbb0-4097-b6f2-2a14c1ea5744"",
                    ""path"": ""<XInputController>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a8e92028-44e4-4556-88e7-7cfbec5f1d48"",
                    ""path"": ""<XInputController>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4f365a87-9704-4ef6-aa49-1315703cc500"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""750569eb-b617-478c-b9b0-711cbe117a12"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""812332ef-7d6e-4aeb-a7b3-77cf2fc9f979"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea6f359f-2325-407c-9d54-a3ec410febec"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d7610ee-e38f-4e61-bcb8-b86f5e026f74"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c01c1aa6-1b72-42aa-961e-d6f7cc0cc9d1"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee0ec584-0ae0-40c6-a543-6082062caade"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Master"",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        }
    ]
}");
            // Player0Gameplay
            m_Player0Gameplay = asset.FindActionMap("Player0Gameplay", throwIfNotFound: true);
            m_Player0Gameplay_PrimaryAttack = m_Player0Gameplay.FindAction("PrimaryAttack", throwIfNotFound: true);
            m_Player0Gameplay_SecondaryAttack = m_Player0Gameplay.FindAction("SecondaryAttack", throwIfNotFound: true);
            m_Player0Gameplay_Jump = m_Player0Gameplay.FindAction("Jump", throwIfNotFound: true);
            m_Player0Gameplay_Grab = m_Player0Gameplay.FindAction("Grab", throwIfNotFound: true);
            m_Player0Gameplay_Movement = m_Player0Gameplay.FindAction("Movement", throwIfNotFound: true);
            m_Player0Gameplay_Defense = m_Player0Gameplay.FindAction("Defense", throwIfNotFound: true);
            m_Player0Gameplay_PrimarySpecial = m_Player0Gameplay.FindAction("PrimarySpecial", throwIfNotFound: true);
            m_Player0Gameplay_SecondarySpecial = m_Player0Gameplay.FindAction("SecondarySpecial", throwIfNotFound: true);
            m_Player0Gameplay_TertiarySpecial = m_Player0Gameplay.FindAction("TertiarySpecial", throwIfNotFound: true);
            m_Player0Gameplay_Selection = m_Player0Gameplay.FindAction("Selection", throwIfNotFound: true);
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

        // Player0Gameplay
        private readonly InputActionMap m_Player0Gameplay;
        private IPlayer0GameplayActions m_Player0GameplayActionsCallbackInterface;
        private readonly InputAction m_Player0Gameplay_PrimaryAttack;
        private readonly InputAction m_Player0Gameplay_SecondaryAttack;
        private readonly InputAction m_Player0Gameplay_Jump;
        private readonly InputAction m_Player0Gameplay_Grab;
        private readonly InputAction m_Player0Gameplay_Movement;
        private readonly InputAction m_Player0Gameplay_Defense;
        private readonly InputAction m_Player0Gameplay_PrimarySpecial;
        private readonly InputAction m_Player0Gameplay_SecondarySpecial;
        private readonly InputAction m_Player0Gameplay_TertiarySpecial;
        private readonly InputAction m_Player0Gameplay_Selection;
        public struct Player0GameplayActions
        {
            private @PlayerUnityInputAsset m_Wrapper;
            public Player0GameplayActions(@PlayerUnityInputAsset wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryAttack => m_Wrapper.m_Player0Gameplay_PrimaryAttack;
            public InputAction @SecondaryAttack => m_Wrapper.m_Player0Gameplay_SecondaryAttack;
            public InputAction @Jump => m_Wrapper.m_Player0Gameplay_Jump;
            public InputAction @Grab => m_Wrapper.m_Player0Gameplay_Grab;
            public InputAction @Movement => m_Wrapper.m_Player0Gameplay_Movement;
            public InputAction @Defense => m_Wrapper.m_Player0Gameplay_Defense;
            public InputAction @PrimarySpecial => m_Wrapper.m_Player0Gameplay_PrimarySpecial;
            public InputAction @SecondarySpecial => m_Wrapper.m_Player0Gameplay_SecondarySpecial;
            public InputAction @TertiarySpecial => m_Wrapper.m_Player0Gameplay_TertiarySpecial;
            public InputAction @Selection => m_Wrapper.m_Player0Gameplay_Selection;
            public InputActionMap Get() { return m_Wrapper.m_Player0Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Player0GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IPlayer0GameplayActions instance)
            {
                if (m_Wrapper.m_Player0GameplayActionsCallbackInterface != null)
                {
                    @PrimaryAttack.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimaryAttack;
                    @PrimaryAttack.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimaryAttack;
                    @PrimaryAttack.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimaryAttack;
                    @SecondaryAttack.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondaryAttack;
                    @SecondaryAttack.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondaryAttack;
                    @SecondaryAttack.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondaryAttack;
                    @Jump.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnJump;
                    @Grab.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnGrab;
                    @Grab.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnGrab;
                    @Grab.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnGrab;
                    @Movement.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnMovement;
                    @Defense.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnDefense;
                    @Defense.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnDefense;
                    @Defense.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnDefense;
                    @PrimarySpecial.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimarySpecial;
                    @PrimarySpecial.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimarySpecial;
                    @PrimarySpecial.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnPrimarySpecial;
                    @SecondarySpecial.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondarySpecial;
                    @SecondarySpecial.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondarySpecial;
                    @SecondarySpecial.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSecondarySpecial;
                    @TertiarySpecial.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnTertiarySpecial;
                    @TertiarySpecial.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnTertiarySpecial;
                    @TertiarySpecial.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnTertiarySpecial;
                    @Selection.started -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSelection;
                    @Selection.performed -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSelection;
                    @Selection.canceled -= m_Wrapper.m_Player0GameplayActionsCallbackInterface.OnSelection;
                }
                m_Wrapper.m_Player0GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PrimaryAttack.started += instance.OnPrimaryAttack;
                    @PrimaryAttack.performed += instance.OnPrimaryAttack;
                    @PrimaryAttack.canceled += instance.OnPrimaryAttack;
                    @SecondaryAttack.started += instance.OnSecondaryAttack;
                    @SecondaryAttack.performed += instance.OnSecondaryAttack;
                    @SecondaryAttack.canceled += instance.OnSecondaryAttack;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Grab.started += instance.OnGrab;
                    @Grab.performed += instance.OnGrab;
                    @Grab.canceled += instance.OnGrab;
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Defense.started += instance.OnDefense;
                    @Defense.performed += instance.OnDefense;
                    @Defense.canceled += instance.OnDefense;
                    @PrimarySpecial.started += instance.OnPrimarySpecial;
                    @PrimarySpecial.performed += instance.OnPrimarySpecial;
                    @PrimarySpecial.canceled += instance.OnPrimarySpecial;
                    @SecondarySpecial.started += instance.OnSecondarySpecial;
                    @SecondarySpecial.performed += instance.OnSecondarySpecial;
                    @SecondarySpecial.canceled += instance.OnSecondarySpecial;
                    @TertiarySpecial.started += instance.OnTertiarySpecial;
                    @TertiarySpecial.performed += instance.OnTertiarySpecial;
                    @TertiarySpecial.canceled += instance.OnTertiarySpecial;
                    @Selection.started += instance.OnSelection;
                    @Selection.performed += instance.OnSelection;
                    @Selection.canceled += instance.OnSelection;
                }
            }
        }
        public Player0GameplayActions @Player0Gameplay => new Player0GameplayActions(this);
        private int m_MasterSchemeIndex = -1;
        public InputControlScheme MasterScheme
        {
            get
            {
                if (m_MasterSchemeIndex == -1) m_MasterSchemeIndex = asset.FindControlSchemeIndex("Master");
                return asset.controlSchemes[m_MasterSchemeIndex];
            }
        }
        public interface IPlayer0GameplayActions
        {
            void OnPrimaryAttack(InputAction.CallbackContext context);
            void OnSecondaryAttack(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnGrab(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnDefense(InputAction.CallbackContext context);
            void OnPrimarySpecial(InputAction.CallbackContext context);
            void OnSecondarySpecial(InputAction.CallbackContext context);
            void OnTertiarySpecial(InputAction.CallbackContext context);
            void OnSelection(InputAction.CallbackContext context);
        }
    }
}
