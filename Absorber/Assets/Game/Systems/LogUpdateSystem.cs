using System;
using System.Collections.Generic;
using System.Linq;
using EcsRx.Events;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Systems;
using EcsRx.Unity.Extensions;
using Game.Components;
//using Game.Events;
using UnityEngine;
using UnityEngine.UI;
using UniRx;


namespace Game.Systems
{
    public class LogUpdateSystem : IManualSystem
    {
        public IGroup Group { get; } = new Group(typeof(PlayerControlledComponent), typeof(MovementComponent));
        private Text _isMovementText;
        private Text _movementVelocityText;
        private LogComponent _logComponent;
        private PlayerControlledComponent _playerControlledComponent;
        private MovementComponent _movementComponent;
        private readonly IEventSystem _eventSystem;
        private readonly IList<IDisposable> _subscriptions = new List<IDisposable>();

        public LogUpdateSystem(IEventSystem eventSystem)
        {
            _eventSystem = eventSystem;
        }

        public void StartSystem(IObservableGroup group)
        {
            this.WaitForScene()
                .Subscribe(x => {
                    var player = group.First();
                    _movementComponent = player.GetComponent<MovementComponent>();
                    _movementVelocityText = GameObject.Find("MovementVelocity").GetComponent<Text>();
                    _isMovementText = GameObject.Find("IsMovement").GetComponent<Text>();
                    SetupSubscriptions();
                });
           
        }
        private void SetupSubscriptions() {
            _movementComponent.Velocity.DistinctUntilChanged()
                .Subscribe(velocityNumber => _movementVelocityText.text = $"Velocity {_movementComponent.Velocity.Value} .")
                .AddTo(_subscriptions);
            _movementComponent.Velocity.DistinctUntilChanged()
                .Subscribe(movementChecker => _isMovementText.text = $"Is Moving {_movementComponent.IsMoving.Value} .")
                .AddTo(_subscriptions);

        }
        public void StopSystem(IObservableGroup group)
        { _subscriptions.DisposeAll(); }
    }
    
}