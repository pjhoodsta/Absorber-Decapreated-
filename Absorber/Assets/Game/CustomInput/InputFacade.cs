using System;
using UnityEngine;
using Zenject;
using EcsRx.Components;
using Game.Components;
using Game.CustomInput;

namespace Game
{
    public class InputFacade
    {
        //public StandardInputComponent StandardInputComponent;
        readonly UnityInputHandler _unityInputHandler;
        public StandardInputComponent StandardInputComponent;
        public InputFacade(StandardInputComponent standardInputComponent, UnityInputHandler unityInputHandler)
        {
            StandardInputComponent = standardInputComponent;
            _unityInputHandler = unityInputHandler;
           // StandardInputComponent = new StandardInputComponent();
        }
        public class Factory : PlaceholderFactory<InputFacade> {
        }
    }
}