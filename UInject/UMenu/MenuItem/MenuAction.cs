﻿using System;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuAction : MenuItem
    {
        public delegate void MAction();
        private readonly MAction _itemAction;

        public MenuAction(string title, MAction itemAction)
        {
            this.Title = title;
            this._itemAction = itemAction;
        }

        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.color = Color.white;
            if (GUI.Button(new Rect(pos.x, pos.y, pos.width - 60f, pos.height), Title, skin.button))
                _itemAction();
        }
    }
}
