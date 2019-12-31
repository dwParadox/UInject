using UnityEngine;

using UInject.ULog;
using UInject.UMenu;

namespace UInject
{
    class UInject_Object : MonoBehaviour
    {
        private void Start()
        {
            UDebug.Log(LogMessageType.INFO, "=====================================================================");
            UDebug.Log(LogMessageType.INFO, "UInject Framework - Loaded");
        }

        void Update()
        {
            MenuManager.OpenClose();
            ComponentRegistrar.HandleRegistrar();
        }

        private void OnGUI()
        {
            UDebug.RenderLogger();

            foreach (var m in MenuManager.menuManagers)
                m.Render();
        }
    }
}
