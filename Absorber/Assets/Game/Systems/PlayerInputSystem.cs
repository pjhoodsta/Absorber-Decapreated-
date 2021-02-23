using System;
using System.Collections;
using System.Linq;
using EcsRx.Attributes;
using EcsRx.Collections;
using EcsRx.Collections.Database;
using EcsRx.Entities;
using EcsRx.Events;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Plugins.ReactiveSystems.Systems;
using EcsRx.Systems;
using EcsRx.Unity.Extensions;
using Game.Components;
using Game.CustomInput;
using Game.Enums;
using UniRx;
using UnityEngine;
///using Game.Events;
//using Game.Events;
using UnityEngine;



namespace Game.Systems {
    [Priority(1)]
    public class PlayerInputSystem : IReactToGroupSystem
    {
        private readonly IEventSystem _eventSystem;

        private IDisposable _updateSubscription;
        private readonly IObservableGroup _inputAccessor;

        public IGroup Group { get; } = new Group(typeof(StandardInputComponent));

        public IObservable<IObservableGroup> ReactToGroup(IObservableGroup group)
        {
            return Observable.EveryUpdate().Select(x => group);
        }
        
        public PlayerInputSystem( IEventSystem eventSystem, IObservableGroupManager observableGroupManager) {
            _eventSystem = eventSystem;
            _inputAccessor = observableGroupManager.GetObservableGroup(new Group(typeof(StandardInputComponent)));
            
        }
        public void Process(IEntity entity)
        {

            var inputComponent = entity.GetComponent<StandardInputComponent>();
            UnityInputWrapper input = inputComponent.UnityInputWrapper;
            if (input.VelocityByMovement == Vector2.zero) return;
            Debug.Log("getting input");
        }

     

    }

}