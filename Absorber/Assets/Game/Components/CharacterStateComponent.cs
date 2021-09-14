using System;
using System.Collections.Generic;
using EcsRx.Components;
using UniRx;
using UnityEngine;
using Zenject;
using Game.Components;
using Game.Enums;

namespace Game.Components {
    
    public class CharacterStateComponent : IComponent {
        public int CurrentState;

        public CharacterStateComponent(int state) {
            CurrentState = state;
        }
        

    }


}
