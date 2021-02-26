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
        //[Inject]
        private readonly UnityInputHandler _unityInputHandler;
        //private Vector2ReactiveProperty _velocityByMovement;
        //public Vector2ReactiveProperty VelocityByMovement
        //{
        //    get { _velocityByMovement.Value = _unityInputHandler.VelocityByMovement;
        //        return _velocityByMovement;
        //    }
        //}
        public Vector2 VelocityByMovement
        {
            get { return _unityInputHandler.VelocityByMovement; }
        }

        public StandardInputComponent(UnityInputHandler unityInputHandler)
        {
            _unityInputHandler = unityInputHandler;
        }



    }

}
