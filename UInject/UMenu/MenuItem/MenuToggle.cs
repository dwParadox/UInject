﻿using UnityEngine;

namespace UInject.UMenu
{
    public class MenuToggle : MenuItem
    {
        public MenuToggle(string title)
        {
            this.Title = title;
        }

        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.color = Color.white;
            Enabled = GUI.Toggle(pos, Enabled, Title, skin.toggle);
        }
    }
}
