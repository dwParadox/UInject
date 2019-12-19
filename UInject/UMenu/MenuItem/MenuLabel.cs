using UnityEngine;

namespace UInject.UMenu
{
    public class MenuLabel : MenuItem
    {
        public MenuLabel(string title)
        {
            this.Title = title;
        }

        public override void Handle(int itemId, Rect pos)
        {
            GUI.color = Color.white;
            GUI.Label(pos, Title);
        }
    }
}
