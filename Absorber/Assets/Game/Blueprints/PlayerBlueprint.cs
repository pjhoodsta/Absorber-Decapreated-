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
        [Inject]
        UnityInputHandler _unityInputHandler;

        public PlayerBlueprint()
        {
            
        }

        public void Apply(IEntity entity) {
            
            //standardInputComponent.UnityInputWrapper = _unityInputWrapper;

            entity.AddComponents(
                _unityInputHandler.StandardInputComponent,
                new StandardInputComponent(),
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

