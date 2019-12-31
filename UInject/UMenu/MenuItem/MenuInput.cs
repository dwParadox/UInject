using UnityEngine;

namespace UInject.UMenu
{
    public class MenuInput : MenuItem
    {
        public MenuInput(string title)
        {
            this.Title = title;
        }

        public override void Handle(int itemId, Rect pos, GUISkin skin)
        {
            GUI.color = Color.white;
            GUI.Label(pos, Title);
            this.Input = GUI.TextField(new Rect(250f, pos.y + 5f, 210f, 20f), this.Input, skin.textField);
        }
    }
}
