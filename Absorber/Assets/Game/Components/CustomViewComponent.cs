using System;
using EcsRx.Components;
using UniRx;
using UnityEngine;

namespace Game.Components
{
    public class CustomViewComponent : IComponent
    {
        public GameObject CustomView { get; set; }
        public Transform Transform { get; set; }

    }
}