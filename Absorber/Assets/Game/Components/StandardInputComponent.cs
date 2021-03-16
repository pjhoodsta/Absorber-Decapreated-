using System;
using System.Collections;
using EcsRx.Components;
using UniRx;
using UnityEngine.InputSystem;
using Unity;
using EcsRx.UnityEditor.MonoBehaviours;
using Game.CustomInput;
using Zenject;
using UnityEngine;
namespace Game.Components
{


    public class StandardInputComponent : IComponent
    {
        public Vector2ReactiveProperty VelocityByMovement;
      
        public StandardInputComponent()
        {
            
        }



    }

}
