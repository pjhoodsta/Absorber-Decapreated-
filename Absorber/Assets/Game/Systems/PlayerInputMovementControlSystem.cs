using EcsRx.Entities;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Plugins.ReactiveSystems.Systems;
using Game.Components;
using System;
using UniRx;

namespace Game.Systems {
    public class PlayerInputMovementControlSystem : IReactToGroupSystem {
        public IGroup Group { get; } = new Group(typeof(MovementComponent), typeof(PlayerControlledComponent));

        public PlayerInputMovementControlSystem() {
        }

        public IObservable<IObservableGroup> ReactToGroup(IObservableGroup group) {
            return Observable.EveryUpdate().Select(x => group);
        }
        public void Process(IEntity entity) {
        }

    }


}


