using System;
using EcsRx.Collections;
using EcsRx.Collections.Entity;
using EcsRx.Extensions;
using EcsRx.Unity.Extensions;
using EcsRx.Infrastructure.Extensions;
using EcsRx.Plugins.Views.Components;
using EcsRx.Zenject;
using Game.Blueprints;
using Game.Components;
//using Game.Installers;
//using Game.Configuration;
using UniRx;
using UnityEngine;
using Zenject;
namespace Game {
    public class Application : EcsRxApplicationBehaviour {
        private IEntityCollection defaultCollection;
        protected override void LoadModules() {
         
            base.LoadModules();
            //Container.LoadModule<CharacterStatesModule>();
           
        }
       

        protected override void ApplicationStarted() {
            defaultCollection = EntityDatabase.GetCollection();

            var player = defaultCollection.CreateEntity(new PlayerBlueprint());
        }
    }

}

