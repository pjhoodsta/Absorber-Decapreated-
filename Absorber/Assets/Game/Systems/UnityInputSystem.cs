using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using EcsRx.Events;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Systems;
using EcsRx.Unity.Extensions;
using Game.Components;
using Game.Groups;
using Game.CustomInput;
using Zenject;
using UnityEngine;
using UnityEngine.UI;


namespace Game.Systems {
    public class UnityInputSystem : IManualSystem {
        public IGroup Group => new PlayerGroup();
        //private StandardInputComponent _inputComponent;
        [Inject]
        private UnityInputHandler _unityInputHandler;
        private PlayerControlledComponent _playerControlledComponent;
        private MovementComponent _movementComponent;

        private readonly IEventSystem _eventSystem;
        private readonly IList<IDisposable> _subscriptions = new List<IDisposable>();


        public UnityInputSystem(IEventSystem eventSystem) {
            _eventSystem = eventSystem;
        }

        public void StartSystem(IObservableGroup group) {
            this.WaitForScene().Subscribe(x => {
                var player = group.First();
                _movementComponent = player.GetComponent<MovementComponent>();
                Observable.EveryUpdate()
                  .Select(x => _unityInputHandler.VelocityByMovement.DistinctUntilChanged())
                  .Subscribe(x => _movementComponent.Velocity.Value = _unityInputHandler.VelocityByMovement.Value)
                    .AddTo(_subscriptions);
            }
                );
        }
      
        public void StopSystem(IObservableGroup group) { _subscriptions.DisposeAll(); }
    }

}