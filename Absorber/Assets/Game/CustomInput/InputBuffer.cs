using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.CustomInput {
    public class PlayerInputBufferContainer  {
        public Queue<InputBuffer> InputBuffers;
    }
    public class InputBuffer {
        public string DisplayName;
        public bool CanExecute;
        public bool HoldUp;
        public bool ReleaseHold;

    }

}
