using System.Collections.Generic;
using EcsRx.Blueprints;
using EcsRx.Entities;
using EcsRx.Extensions;
using EcsRx.Plugins.Views.Components;
using Game.Components;
using Game.Enums;
using Game.CustomInput;
using UnityEngine;
using Zenject;
namespace Game.Blueprints {
    public class PlayerBlueprint : IBlueprint {
        private readonly UnityInputWrapper _unityInputWrapper;

        public PlayerBlueprint(UnityInputWrapper unityInputWrapper)
        {
            _unityInputWrapper = unityInputWrapper;
        }

        public void Apply(IEntity entity) {
            var standardInputComponent = new StandardInputComponent();
            standardInputComponent.UnityInputWrapper = _unityInputWrapper;

            entity.AddComponents(
                standardInputComponent,
                new PlayerControlledComponent(), 
                new ViewComponent(), 
                new CameraFollowsComponent(), 
                new MovementComponent(), 
                new AnimatorComponent(),  
                new CharacterStateComponent()
                
                );
        }

    }

}

