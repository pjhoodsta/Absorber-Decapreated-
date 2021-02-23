using System;
using EcsRx.Components;
using UniRx;
using UnityEngine.InputSystem;
using Unity;
using EcsRx.UnityEditor.MonoBehaviours;
using Game.CustomInput;
namespace Game.Components
{


    public class StandardInputComponent : IComponent
    {
        public UnityInputWrapper UnityInputWrapper;
        public StandardInputComponent()
        {
            
        }



    }

}
