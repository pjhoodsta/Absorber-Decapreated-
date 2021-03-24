using System;
using System.Collections.Generic;
using Game.CustomInput;
using Game.Components;
using UnityEngine;
using Zenject;

namespace Game
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField]
        GameObject InputPrefab;
        public override void InstallBindings()
        {
            Container.BindFactory<InputFacade, InputFacade.Factory>()
           .FromSubContainerResolve().ByNewPrefabInstaller<InputInstaller>(InputPrefab);
           // Container.BindFactory<StandardInputComponent, InputFacade, InputFacade.Factory>().FromSubContainerResolve().ByNewContextPrefab<InputInstaller>(InputPrefab);
            //Container.Bind<UnityInputHandler>()
            //    .FromComponentInNewPrefab(InputPrefab)
            //    .UnderTransformGroup("Input")
            //    .AsSingle();

        }
        
        
    }
    
}
