using System;
using UnityEngine;
using Game.CustomInput;
using Zenject;

namespace Game.CustomInput
{
    public class InputPrefabInstaller : MonoInstaller
    {
        [Inject]
        private readonly Settings _settings = null;
        public override void InstallBindings()
        {
            Container.Bind<UnityInputHandler>()
                .FromComponentInNewPrefab(_settings.InputPrefab)
                .UnderTransformGroup("Input")
                .AsSingle();

        }
        [Serializable]
        public class Settings
        {
            public GameObject InputPrefab;
        }
    }
    
}
