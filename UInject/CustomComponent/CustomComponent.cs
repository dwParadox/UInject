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

        /* Instantiates a new registrar for this CustomComponent that will handle attaching to base components created later */
        public static void Register()
        {
            try
            {
                UDebug.Log(LogMessageType.INFO, "Registering object (" + typeof(TSource).Name + " as " + typeof(TNew).Name + ")");

                ComponentRegistrar.Register(typeof(TSource), typeof(TNew));
            }
            catch (Exception e)
            {
                UDebug.Log(LogMessageType.ERROR, "<CustomComponent.Register> " + e.ToString());
            }

        }

        public T GetPrivateField<T>(object obj, string fieldName)
        {
            T fieldData = (T)obj.GetType().GetField(fieldName, BindingFlags.NonPublic)?.GetValue(obj);
            if (fieldData != null)
                return fieldData;
            else
                return default(T);
        }

        public void SetPrivateField<T>(object obj, string fieldName, object value)
        {
            obj.GetType().GetField(fieldName, BindingFlags.NonPublic)?.SetValue(obj, value);
        }

        protected virtual void Start() { }
        protected virtual void Update() { }
        protected virtual void OnGUI() { }
    }
}
