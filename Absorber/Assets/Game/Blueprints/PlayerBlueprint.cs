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
<<<<<<< HEAD
=======
        [Inject]
        UnityInputHandler _unityInputHandler;
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f

        public PlayerBlueprint()
        {
            
        }

        public void Apply(IEntity entity) {
<<<<<<< HEAD
            //var standardInputComponent = new StandardInputComponent(_unityInputHandler);
            //standardInputComponent.UnityInputWrapper = _unityInputWrapper;

            entity.AddComponents(
=======
            
            //standardInputComponent.UnityInputWrapper = _unityInputWrapper;

            entity.AddComponents(
                _unityInputHandler.StandardInputComponent,
                new StandardInputComponent(),
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f
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

