using System;
using System.Collections;
using EcsRx.Components;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Game.Components
{
    public class LogComponent : IComponent
    {
        public bool IsEnabled;
        public LogComponent ()
        {
            IsEnabled = true;
        }
    }
}