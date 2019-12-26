using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UInject
{
    public static class ComponentHelper
    {
        public static T GetPrivateField<T>(this object obj, string fieldName)
        {
            T fieldData = (T)obj.GetType().GetField(fieldName, BindingFlags.NonPublic)?.GetValue(obj);
            if (fieldData != null)
                return fieldData;
            else
                return default;
        }

        public static void SetPrivateField<T>(this object obj, string fieldName, object value)
        {
            obj.GetType().GetField(fieldName, BindingFlags.NonPublic)?.SetValue(obj, value);
        }

    }
}
