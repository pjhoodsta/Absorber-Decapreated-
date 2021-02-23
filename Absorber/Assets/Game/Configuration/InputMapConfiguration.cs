using System;
using UnityEngine;

using Game.Configuration;
using Game.Components;
using Game.Systems;
using Game.CustomInput;
using Zenject;

namespace Game.Configuration {
    [CreateAssetMenu(fileName = "Configuration", menuName = "Configuration/InputMap")]
    public class InputMapConfiguration : ScriptableObjectInstaller<InputMapConfiguration> {
        public PlayerInputContainer.Settings InputMap;
        public override void InstallBindings() {
            Container.BindInstances(InputMap);
        }
    }
}

