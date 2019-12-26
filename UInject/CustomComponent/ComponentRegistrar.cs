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
            var objects = FindObjectsOfType(sourceType);

            if (objects.Length <= 0)
                return;

            foreach (var c in objects)
            {
                var component = c as Component;

                if (component == null)
                    continue;

                if (component.gameObject == null)
                    continue;

                if (component.GetComponentInParent(newType) != null)
                    continue;

                component.gameObject.AddComponent(newType);
            }
        }
    }
}
