using EcsRx.Collections;
using EcsRx.Collections.Database;
using EcsRx.Entities;
using EcsRx.Events;
using EcsRx.Groups;
using EcsRx.Unity.Dependencies;
using EcsRx.Unity.Systems;
using EcsRx.Plugins.Views.Components;
using Game.Components;
using UnityEngine;
using Zenject;

namespace Game.ViewResolvers {
    public class PlayerViewResolver : PrefabViewResolverSystem {
        public override IGroup Group { get; } = new Group(typeof(PlayerControlledComponent), typeof(ViewComponent));

        protected override GameObject PrefabTemplate { get; } = Resources.Load<GameObject>("Prefabs/Player");

        public PlayerViewResolver(IEntityDatabase entityDatabase, IEventSystem eventSystem, IUnityInstantiator instantiator)
            : base(entityDatabase, eventSystem, instantiator) { }
        protected override void OnViewCreated(IEntity entity, GameObject view) { view.name = "Player"; }

    }
}