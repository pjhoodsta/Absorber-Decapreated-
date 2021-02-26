using EcsRx.Infrastructure.Dependencies;
using EcsRx.Infrastructure.Extensions;
using System.Collections.Generic;
using Game.Enums;
using Game.Components;
using Game.CustomInput;
namespace Game.Installers {


    public class CustomInputModule : IDependencyModule {
        public void Setup(IDependencyContainer container) {
            //container.Bind<UnityInputWrapper>(new BindingConfiguration { AsSingleton = true});
            //container.Bind<>
            
        }
    }


}