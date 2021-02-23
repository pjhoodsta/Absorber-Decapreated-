using System;
using EcsRx.Components;
//using UniRx;
using UnityEngine;
using Zenject;

using Game.Enums;
namespace Game.Components {
    public class AnimatorComponent : IComponent {
        //animator.GetcurrentAnimatorStateInfo(0).length
        // 0 means current state
        public Animator animator;
        public AnimatorComponent() {
           
        }

    }


}
