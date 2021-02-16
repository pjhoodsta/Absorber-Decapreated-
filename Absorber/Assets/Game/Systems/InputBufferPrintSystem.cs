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
using UniRx;
using UnityEngine;
using UnityEngine.UI;
namespace Game.Systems {
    public class InputBufferPrintSystem : IManualSystem {
        //public IGroup Group { get; } = new Group(typeof(LevelComponent));
        public InputBufferPrintSystem(IEventSystem eventSystem) {
          //  _eventSystem = eventSystem;
        }
        public void StartSystem(IObservableGroup group) {
            this.WaitForScene()
                .Subscribe(x => {
                    var level = @group.First();
                    _levelComponent = level.GetComponent<LevelComponent>();
                    _levelText = GameObject.Find("LevelText").GetComponent<Text>();
                    SetupSubscriptions();
                });
        }

        private void SetupSubscriptions() {
            _levelComponent.Level.DistinctUntilChanged()
                .Subscribe(levelNumber => _levelText.text = $"Day {levelNumber}")
                .AddTo(_subscriptions);

            _eventSystem.Receive<PlayerKilledEvent>()
                .Subscribe(eventData => _levelText.text = $"After {_levelComponent.Level.Value} days, you starved.")
                .AddTo(_subscriptions);
        }

        public void StopSystem(IObservableGroup group) { _subscriptions.DisposeAll(); }
    }


}
