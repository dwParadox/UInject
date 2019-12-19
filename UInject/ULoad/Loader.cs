using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UInject.ULoad
{
    public class Loader<T> : MonoBehaviour
        where T : Component
    {
        public GameObject LoadedObject { get; }
        public Loader()
        {
            LoadedObject = new GameObject("UInject_" + typeof(T).Name);
        }

        public void LoadObject()
        {
            LoadedObject.AddComponent<T>();
            GameObject.DontDestroyOnLoad(LoadedObject);
        }

        public void UnloadObject()
        {
            var customComponents = ComponentRegistrar.GetCustomComponents();
            if (customComponents != null)
            {
                foreach (var t in customComponents)
                {
                    foreach (var c in FindObjectsOfType(t))
                        GameObject.Destroy(c);
                }
            }

            GameObject.Destroy(LoadedObject);
        }
    }
}
