using UnityEngine;

namespace UInject.UMenu
{
    public abstract class MenuItem
    {
        public string Title { get; protected set; }
        public float Value { get; set; }
        public bool Enabled { get; set; }

        public abstract void Handle(int itemId, Rect pos);
    }
}
