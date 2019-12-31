using System;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuFunc : MenuItem
    {
        public delegate void MFunc(object param);
        private readonly MFunc _itemAction;

        private object _param;

        public MenuFunc(string title, MFunc itemAction, object param)
        {
            this.Title = title;
            this._itemAction = itemAction;
            this._param = param;
        }

        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.color = Color.white;
            if (GUI.Button(new Rect(pos.x, pos.y, pos.width - 60f, pos.height), Title, skin.button))
                _itemAction(_param);
        }
    }
}
