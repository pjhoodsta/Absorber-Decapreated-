using EcsRx.Infrastructure.Dependencies;
using EcsRx.Infrastructure.Extensions;
using System.Collections.Generic;
using Game.Enums;
using Game.Components;
namespace Game.Installers {


    public class CustomInputModule : IDependencyModule {
        public void Setup(IDependencyContainer container) {
            //SetupCharacterStateDataContainers(container);
        }
        private void SetupCharacterStateDataContainers(IDependencyContainer container) {
           // container.Bind<CharacterStateAnimationCollection>(new BindingConfiguration { AsSingleton = true });
        }
    }


}