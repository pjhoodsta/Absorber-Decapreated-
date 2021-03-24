using System;
using UnityEngine;
using Zenject;
using Game.Components;
using Game.CustomInput;

namespace Game.CustomInput
{
    public class InputInstaller : Installer<InputInstaller> {
        //[Inject]
        StandardInputComponent _standardInputComponent;
        public InputInstaller(StandardInputComponent standardInputComponent)
        {
            _standardInputComponent = standardInputComponent;
        }
        public override void InstallBindings() { 
            Container.Bind<InputFacade>().AsSingle();
            Container.BindInterfacesTo<UnityInputHandler>().AsSingle();
            Container.BindInstance(_standardInputComponent).WhenInjectedInto<UnityInputHandler>();
            //Container.Bind<UnityInputHandler>().FromNewComponentOnRoot().AsSingle();
            //Container.Bind<StandardInputComponent>().AsSingle(); 
        }
    }
}