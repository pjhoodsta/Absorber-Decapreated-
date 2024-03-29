﻿using System;
using EcsRx.Components;
using UniRx;
using UnityEngine;
using Zenject;
namespace Game.Components {
    public class MovementComponent : IComponent, IDisposable {

        public bool StopMovement { get; set; }
 
        public FloatReactiveProperty CurrentDistance { get; set; }
        public Vector3ReactiveProperty Velocity { get; set; }
        public float MaxDistance { get; set; }
       
        public MovementComponent() {
            CurrentDistance = new FloatReactiveProperty();
            Velocity = new Vector3ReactiveProperty();
            StopMovement = false;
            MaxDistance = 0f;
           
        }
        public void Dispose() {
            CurrentDistance.Dispose();
            Velocity.Dispose();
        }
  

    }

}
