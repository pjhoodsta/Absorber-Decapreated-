using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using EcsRx.Events;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Plugins.ReactiveSystems.Systems;
using EcsRx.Systems;
using EcsRx.Unity.Extensions;
using Game.Components;
using UnityEngine;
using UnityEngine.UI;


namespace Game.Systems {
    public class LogUpdateSystem : IManualSystem {
        public IGroup Group { get; } = new Group(typeof(StandardInputComponent));
        private StandardInputComponent _inputComponent;
        private readonly IEventSystem _eventSystem;
        private readonly IList<IDisposable> _subscriptions = new List<IDisposable>();
        private Text _velocityText;

        public LogUpdateSystem(IEventSystem eventSystem) {
            _eventSystem = eventSystem;
        }

        public void StartSystem(IObservableGroup group) {
            this.WaitForScene().Subscribe(x => {
                var input = group.First();
                _inputComponent = input.GetComponent<StandardInputComponent>();
                _velocityText = GameObject.Find("VelocityText").GetComponent<Text>();

            }
                );
        }
        private void SetupSubscriptions() {
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
        }
        public void StopSystem(IObservableGroup group) { _subscriptions.DisposeAll(); }
    }

}