using UnityEngine;

namespace UInject
{
    class UInjectLoader
    {
        private static void Load()
        {
            GameObject mainObj = new GameObject("UInject");
            mainObj.AddComponent<UInject_Object>();
            GameObject.DontDestroyOnLoad(mainObj);
        }
    }
}
