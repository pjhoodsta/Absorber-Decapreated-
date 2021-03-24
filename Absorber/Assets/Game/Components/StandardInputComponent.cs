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
<<<<<<< HEAD
        
        //private Vector2ReactiveProperty _velocityByMovement;
        //public Vector2ReactiveProperty VelocityByMovement
        //{
        //    get { _velocityByMovement.Value = _unityInputHandler.VelocityByMovement;
        //        return _velocityByMovement;
        //    }
        //}
       
=======
        public Vector2ReactiveProperty VelocityByMovement;
      
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f
        public StandardInputComponent()
        {
            
        }



    }

}
