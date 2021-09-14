using System;
using EcsRx.Collections;
using EcsRx.Collections.Entity;
using EcsRx.Groups;
using EcsRx.Extensions;
using EcsRx.Unity.Extensions;
using EcsRx.Infrastructure.Extensions;
using EcsRx.Plugins.Views.Components;
using EcsRx.Zenject;
using Game.Components;

namespace Game.Groups
{
    public class PlayerGroup : IGroup
    {
        public Type[] RequiredComponents { get; } = { 
            typeof(AnimatorComponent), 
            typeof(CameraFollowsComponent), 
            typeof(CharacterStateComponent),
            typeof(ViewComponent),
            typeof(MovementComponent),
            typeof(PlayerControlledComponent),
            typeof(CustomViewComponent)
        };
        public Type[] ExcludedComponents { get; } = new Type[0];
    }
}