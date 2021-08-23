using System;
using System.Collections.Generic;
using System.Linq;
using EcsRx.Collections;
using EcsRx.Collections.Database;
using EcsRx.Entities;
using EcsRx.Events;
using EcsRx.Groups;
using EcsRx.Unity.Dependencies;
using EcsRx.Unity.Systems;
using EcsRx.Plugins.Views.Components;
using EcsRx.Extensions;
using Game.Components;
using Game.Groups;
using Game.Extensions;
using UnityEngine;
using Zenject;


namespace Game.Extensions
{
    public static class ViewRosovlerExtention
    {
        public static void OnCharacterViewCreated(IEntity entity, GameObject view)
        {
            var viewComponent = entity.GetComponent<CustomViewComponent>();
            viewComponent.CustomView = view;
            viewComponent.Transform = view.transform;
            var animatorComponent = entity.GetComponent<AnimatorComponent>();
            animatorComponent.animator = view.GetComponent<Animator>();

            //characterStateComponent



        }
    }
}