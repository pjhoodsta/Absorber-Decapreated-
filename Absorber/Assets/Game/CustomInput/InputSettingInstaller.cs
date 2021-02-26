using UnityEngine;
//using Game.CustomInput;
using Zenject;
namespace Game.CustomInput
{
    [CreateAssetMenu(fileName = "InputSettingInstaller", menuName = "Installers/InputSettingInstaller")]
    public class InputSettingInstaller : ScriptableObjectInstaller<InputSettingInstaller>
    {
        public InputPrefabInstaller.Settings InputPrefabInstaller;
        public override void InstallBindings()
        {
            Container.BindInstance(InputPrefabInstaller).IfNotBound();
        }
    }

}
