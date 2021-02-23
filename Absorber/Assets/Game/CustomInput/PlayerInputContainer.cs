using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using Zenject;
namespace Game.CustomInput {
    /// <summary>
    /// example, after implenmenting similar one, delete this file!
    /// </summary>
    public class PlayerInputContainer {
        ///readonly Settings _settings;
        public PlayerInputContainer(Settings settings) {
            ///_settings = settings;
        }


        [Serializable]
        public class Settings {
            ///public PlayerInputController PlayerInputController;
        }

    }

}

