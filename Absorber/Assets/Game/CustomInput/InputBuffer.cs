using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.CustomInput {
    public class PlayerInputBufferContainer  {
        public Queue<InputBuffer> InputBuffers;
    }
    public struct InputBuffer {
        public int InputTypeIndex;
        public bool CanExecute;
        public bool HoldUp;
        public bool ReleaseHold;

    }

}
