using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace UInject.Utilities
{
    public static class Generic
    {

        private static Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();

        public static string Remove(this string String, string stringToRemove)
        {
            return String.Replace(stringToRemove, "");
        }

        public static void PrintFields(Type type, object instance)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            List<string> list = new List<string>();
            string listString = "";

            list.Add("============================================================================================");
            foreach (var item in fields)
            {
                list.Add(string.Format("{0}: {1}", item.Name, item.GetValue(instance)));
            }
            list.Add("============================================================================================");
            listString = string.Join("\n", list.ToArray());
            Debug.Log(listString);
        }

        public static TReturn FindResource<TReturn>(string name) where TReturn : UnityEngine.Object
        {
            if (resources.ContainsKey(name))
            {
                try
                {
                    return (TReturn)Convert.ChangeType(resources[name], typeof(TReturn));
                }
                catch (InvalidCastException)
                {
                    return default;
                }
            }
            else
            {
                foreach (var item in Resources.FindObjectsOfTypeAll<TReturn>())
                {
                    if (item.name.Equals(name))
                    {
                        resources.Add(name, item);
                        return (TReturn)Convert.ChangeType(item, typeof(TReturn));
                    }
                }
            }
            return default;
        }
    }

    public static class ImageExtensions
    {
        public static byte[] ToByteArray(this Bitmap image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
