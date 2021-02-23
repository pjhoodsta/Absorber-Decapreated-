using EcsRx.Components;
using UnityEngine;
using UniRx;
namespace Game.Components {
    public class CameraFollowsComponent : IComponent {
        
        public CameraFollowsComponent() {
        }
        public Camera Camera { get; set; }
    }
}

