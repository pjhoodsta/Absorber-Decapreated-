using EcsRx.Entities;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Plugins.ReactiveSystems.Systems;
using Game.Components;
using Game.CustomInput;

using Game.Enums;
using System;
using UniRx;
using UnityEngine;

namespace Game.Systems {


    public class PlayerStandardInputMovementControlSystem : IReactToGroupSystem {
        public IGroup Group { get; } = new Group(typeof(MovementComponent), typeof(PlayerControlledComponent));

       

        public PlayerStandardInputMovementControlSystem(Settings settings) {
        }

        public IObservable<IObservableGroup> ReactToGroup(IObservableGroup group) {
            return Observable.EveryUpdate().Select(x => group);
        }
        public void Process(IEntity entity) {
 

        }
       
        }

        [Serializable]
        public class Settings {

        }
    }


