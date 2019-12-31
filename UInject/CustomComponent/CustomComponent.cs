using System;
using System.Reflection;
using System.Collections.Generic;

using UnityEngine;
using UInject.ULog;

namespace UInject
{
    public class CustomComponent<TSource, TNew> : MonoBehaviour
        where TSource : Component
        where TNew : Component
    {
        protected readonly TSource _component;

        public CustomComponent()
        {
            _component = this.GetComponentInParent<TSource>();
        }

        public static void Register()
        {
            try
            {
                ComponentRegistrar.Register(typeof(TSource), typeof(TNew));
            }
            catch (Exception e)
            {
                UDebug.Log(LogMessageType.ERROR, $"Error registering component ({typeof(TNew).Name}): {e.ToString()}");
            }

        }

        protected virtual void Start() { }
        protected virtual void Update() { }
        protected virtual void OnGUI() { }
    }
}
