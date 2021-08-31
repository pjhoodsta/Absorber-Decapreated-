using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Enums;
//using Game.Extensions;
namespace Game.CustomInput {

    public class ButtonState {
        public static readonly ButtonState OFF = new ButtonState(ButtonStatesEnum.Off);
        public static readonly ButtonState BUTTONDOWN = new ButtonState(ButtonStatesEnum.ButtonDown);
        public static readonly ButtonState BUTTONPRESSED = new ButtonState(ButtonStatesEnum.ButtonPressed);
        public static readonly ButtonState BUTTONUP = new ButtonState(ButtonStatesEnum.ButtonUp);


        private static Dictionary<ButtonStatesEnum, ButtonState> ALL = new Dictionary<ButtonStatesEnum, ButtonState>() {
            { ButtonStatesEnum.Off, OFF},
            { ButtonStatesEnum.ButtonDown, BUTTONDOWN},
            { ButtonStatesEnum.ButtonPressed, BUTTONPRESSED},

        };

        public ButtonState(ButtonStatesEnum buttonState) {
            this.buttonStateEnum = buttonState;
        }
        //public ButtonState ConvertButtonStateInAxis(float axisValue, float threshold) {
        //    ButtonStatesEnum returnStates;
        //    //bool isBelowThreshold = (MathExtentions.CheckNegativeNumber(axisValue)) ? (axisValue < threshold) : (axisValue > threshold);
        //   // returnStates = isBelowThreshold ? ComputeAxisButtonStateOnReleasing() : ComputeAxisButtonStateOnPressing();
        //    return ALL[returnStates];
        //}
        public ButtonStatesEnum ComputeAxisButtonStateOnReleasing() {

            if (buttonStateEnum == ButtonStatesEnum.ButtonPressed)
                return ButtonStatesEnum.ButtonUp;
            return ButtonStatesEnum.Off;
        }

        private ButtonStatesEnum ComputeAxisButtonStateOnPressing() {
            if (buttonStateEnum == ButtonStatesEnum.Off)
                return ButtonStatesEnum.ButtonDown;
            return ButtonStatesEnum.ButtonPressed;
        }

        private readonly ButtonStatesEnum buttonStateEnum;
        public ButtonStatesEnum ButtonStateEnum { get { return buttonStateEnum; } }

    }

}