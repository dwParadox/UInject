using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UInject
{
    public abstract class UMain : MonoBehaviour
    {
        protected abstract void Start();
        protected abstract void Update();
        protected abstract void OnGUI();
    }
}
