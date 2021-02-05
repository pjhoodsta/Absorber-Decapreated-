﻿using System.Collections.Generic;
using EcsRx.Blueprints;
using EcsRx.Entities;
using EcsRx.Extensions;
using EcsRx.Plugins.Views.Components;
using Game.Components;
using Game.Enums;
using UnityEngine;
using Zenject;
namespace Game.Blueprints {
    public class PlayerBlueprint : IBlueprint {
       
        public void Apply(IEntity entity) {
            entity.AddComponents(new PlayerControlledComponent(), 
                new ViewComponent(), 
                new CameraFollowsComponent(), 
                new MovementComponent(), 
                new AnimatorComponent(),  
                new CharacterStateComponent());
        }

    }

}

