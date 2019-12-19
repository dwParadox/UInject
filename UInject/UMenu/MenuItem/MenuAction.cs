using System;
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

        public override void Handle(int itemId, Rect pos)
        {
            GUI.color = Color.white;
            if (GUI.Button(new Rect(pos.x + 10f, pos.y, pos.width - 40f, pos.height), Title))
                _itemAction();
        }
    }
}
