using System;
using System.Collections.Generic;
using System.Linq;
using EcsRx.Events;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Plugins.ReactiveSystems.Systems;
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
        private Text _velocityText;
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
                    _velocityText = GameObject.Find("VelocityText").GetComponent<Text>();
                    SetupSubscriptions();
                });
           
        }
        private void SetupSubscriptions() {
<<<<<<< HEAD
            _movementComponent.Velocity.DistinctUntilChanged()
                .Subscribe(velocityNumber => _velocityText.text = $"Velocity {_movementComponent.Velocity.Value} .")
                .AddTo(_subscriptions);

=======
            _inputComponent.VelocityByMovement.DistinctUntilChanged(x => _inputComponent.VelocityByMovement.Value != Vector2.zero)
                .Subscribe(x => _velocityText.text = _inputComponent.VelocityByMovement.Value.ToString())
                .AddTo(_subscriptions);
            //if (inputComponent.EntityState == EntityStates.Movement) {
            //    if (inputComponent.MovementState == MovementStates.Walk)
            //        Debug.Log("Walking");
            //    else if (inputComponent.MovementState == MovementStates.Run)
            //        Debug.Log("Running");
            //} else
            //    Debug.Log("Idle");
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f
        }
        public void StopSystem(IObservableGroup group)
        { _subscriptions.DisposeAll(); }
    }
    
}