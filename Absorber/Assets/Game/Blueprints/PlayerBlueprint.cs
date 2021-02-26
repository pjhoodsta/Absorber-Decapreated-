using System.Collections.Generic;
using EcsRx.Blueprints;
using EcsRx.Attributes;
using EcsRx.Entities;
using EcsRx.Extensions;
using EcsRx.Plugins.Views.Components;
using Game.Components;
using Game.Enums;
using Game.CustomInput;
using UnityEngine;
using Zenject;
namespace Game.Blueprints {
    [Priority(1)]
    public class PlayerBlueprint : IBlueprint {
        private readonly UnityInputHandler _unityInputHandler;

        public PlayerBlueprint(UnityInputHandler unityInputHandler)
        {
            _unityInputHandler = unityInputHandler;
        }

        public void Apply(IEntity entity) {
            var standardInputComponent = new StandardInputComponent(_unityInputHandler);
            //standardInputComponent.UnityInputWrapper = _unityInputWrapper;

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

