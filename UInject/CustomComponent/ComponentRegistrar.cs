using System;

using UnityEngine;

using UInject.ULog;
using System.Collections.Generic;
using System.Linq;

namespace UInject
{
    public struct RegisteredComponent
    {
        public Type SourceType;
        public Type NewType;

        public RegisteredComponent(Type sourceType, Type newType)
        {
            this.SourceType = sourceType;
            this.NewType = newType;
        }
    }

    public class ComponentRegistrar : MonoBehaviour
    {
        private const int PollingDelay = 5000;
        private static long lastUpdateTime;

        private static List<RegisteredComponent> _components = new List<RegisteredComponent>();

        public static List<Type> GetCustomComponents()
        {
            if (_components.Count <= 0)
                return null;

            return _components.Select(s => s.NewType).ToList();
        }

        public static void Register(Type sourceType, Type newType)
        {
            _components.Add(new RegisteredComponent(sourceType, newType));
        }

        public static void HandleRegistrar()
        {
            long currentTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            if (currentTime - lastUpdateTime > PollingDelay)
            {
                lastUpdateTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

                foreach (var c in _components)
                    ProcessRegistration(c.SourceType, c.NewType);
            }
        }

        private static void ProcessRegistration(Type sourceType, Type newType)
        {
            int registerCount = 0;

            var objects = FindObjectsOfType(sourceType);

            if (objects.Length <= 0)
                return;

            foreach (var obj in objects)
            {
                var gameObj = obj as Component;

                if (gameObj == null)
                {
                    UDebug.Log(LogMessageType.ERROR, sourceType.Name + " could not be converted to GameObject, continuing.");
                    continue;
                }

                if (gameObj.gameObject == null)
                {
                    UDebug.Log(LogMessageType.ERROR, sourceType.Name + " was null, continuing.");
                    continue;
                }

                if (gameObj.GetComponentInParent(newType) != null)
                    continue;

                gameObj.gameObject.AddComponent(newType);

                registerCount++;
            }

            if (registerCount > 0)
                UDebug.Log(LogMessageType.INFO, "(" + newType.Name + ") " + registerCount + " instances registered.");
        }

    }
}
