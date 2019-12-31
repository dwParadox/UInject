using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UInject.UMenu
{
    public class MenuStartScroll : MenuItem
    {
        private Vector2 ScrollPosition = Vector2.zero;
        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            ScrollPosition = GUI.BeginScrollView(new Rect(10f, 49f, 480f, 278f), ScrollPosition, new Rect(0f, 0f, 400f, 6000f), skin.verticalScrollbar, skin.verticalScrollbar);
        }
    }

    public class MenuEndScroll : MenuItem
    {
        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.EndScrollView();
        }
    }
}
